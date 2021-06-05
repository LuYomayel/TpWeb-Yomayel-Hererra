using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
namespace Carrito_de_Compras
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Producto> carrito;
        protected void Page_Load(object sender, EventArgs e)
        {
            carrito = (List<Producto>)Session["carrito"];
            if (carrito == null)
                carrito = new List<Producto>();

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    if (carrito.Find(x => x.Id.ToString() == Request.QueryString["id"]) == null)
                    {
                        List<Producto> listadoOriginal = (List<Producto>)Session["listadoProductos"];
                        carrito.Add(listadoOriginal.Find(x => x.Id.ToString() == Request.QueryString["id"]));
                    }
                }

                //Repeater
                repetidor.DataSource = carrito;
                repetidor.DataBind();
            }

            Session.Add("carrito", carrito);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<Producto> carrito = (List<Producto>)Session["carrito"];
            Producto elim = carrito.Find(x => x.Id.ToString() == argument);
            carrito.Remove(elim);
            Session.Add("carrito", carrito);
            repetidor.DataSource = null;
            repetidor.DataSource = carrito;
            repetidor.DataBind();
        }
    }
}