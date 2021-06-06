using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Carrito_de_Compras
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<ItemCarrito> carrito1;


        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            Producto producto = new Producto();
            Carrito carrito = new Carrito();
            ItemCarrito item = new ItemCarrito();
            ProductoNegocio negocio = new ProductoNegocio();
            producto = negocio.listarProducto1(id);

            item.SubTotal = producto.Precio;
            item.Producto = producto;
            item.Cantidad = 1;

            carrito.Items = (List<ItemCarrito>)Session["carrito"];

            if (carrito.Items == null) carrito.Items = new List<ItemCarrito>();
            carrito.Items.Add(item);

            //if(item!= null) carrito.Items.Add(item);

            
            if (!IsPostBack)
            {
                
                //Repeater
                repetidor.DataSource = carrito.Items;
                repetidor.DataBind();
            }

            Session.Add("carrito2", carrito1);
            
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

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            lblEjemplo.Text = "El valor es: " + ((TextBox)sender).Text;
        }
    }
}