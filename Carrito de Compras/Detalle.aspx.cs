using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
namespace Carrito_de_Compras
{
    public partial class Detalle : System.Web.UI.Page
    {
        public string hola;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            List<Producto> listado = (List<Producto>)Session["listadoProductos"];
            Producto seleccionado = listado.Find(x => x.Id == id);
            lblNombre.Text = seleccionado.Nombre;
            lblMarca.Text = seleccionado.Marca.Nombre;
            lblDescripcion.Text = seleccionado.Descripcion;
            lblCategoria.Text = seleccionado.Categoria.Nombre;
            lblPrecio.Text = Convert.ToString(seleccionado.Precio);
            imgseleccionado.Src = seleccionado.UrlImagen;
            hola = (seleccionado.Id).ToString();
        }
    }
}