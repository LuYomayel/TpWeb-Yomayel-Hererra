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
        Producto producto = new Producto();
        public Carrito carrito = new Carrito();
        ItemCarrito item = new ItemCarrito();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            carrito.Items = (List<ItemCarrito>)Session["carrito"];
            if (carrito.Items == null) carrito.Items = new List<ItemCarrito>();
            
            if (!IsPostBack)
            {
                if(id != null)
                {
                    if(carrito.Items.Find(x => x.Producto.Id.ToString() == id) == null)
                    {
                        List<Producto> listado = (List<Producto>)Session["listadoProductos"];
                        producto = listado.Find(x => x.Id.ToString() == id);

                        item.SubTotal = producto.Precio;
                        item.Producto = producto;
                        item.Cantidad = 1;
                        carrito.FechaCarrito = DateTime.Today;
                        //itemCarritos.Items = (List<ItemCarrito>)Session["carrito"];
                        carrito.Items.Add(item);

                    }
                }
                //Repeater
                repetidor.DataSource = carrito.Items;
                repetidor.DataBind();
            }
            Session.Add("carrito", carrito.Items);
            //Session.Add("carrito", carrito);
            /*
            favoritos = (List<Pokemon>)Session["listaFavoritos"];
            if (favoritos == null)
                favoritos = new List<Pokemon>();

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    if (favoritos.Find(x => x.Id.ToString() == Request.QueryString["id"]) == null)
                    {
                        List<Pokemon> listadoOriginal = (List<Pokemon>)Session["listadoPokemons"];
                        favoritos.Add(listadoOriginal.Find(x => x.Id.ToString() == Request.QueryString["id"]));
                    }
                }

                //Repeater
                repetidor.DataSource = favoritos;
                repetidor.DataBind();
            }

            Session.Add("listaFavoritos", favoritos);
            */
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            carrito.Items = (List<ItemCarrito>)Session["carrito"];
            ItemCarrito item1 = carrito.Items.Find(x => x.Producto.Id.ToString() == argument);
            carrito.Items.Remove(item1);
            Session.Add("carrito", carrito.Items);
            repetidor.DataSource = null;
            repetidor.DataSource = carrito.Items;
            repetidor.DataBind();
            
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}