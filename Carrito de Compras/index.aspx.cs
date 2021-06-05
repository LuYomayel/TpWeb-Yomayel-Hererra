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
    public partial class WebForm2 : System.Web.UI.Page
    {
        public List<Producto> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            Producto producto = new Producto();
           
            try
            {
                lista = negocio.listar();
                Session.Add("listadoProductos",lista);

            }
            catch (Exception) 
            {

                throw;
            }
        }
    }
}