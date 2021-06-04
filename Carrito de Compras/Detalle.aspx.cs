using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
namespace Carrito_de_Compras
{
    public partial class Detalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            List<Producto> listado = (List<Producto>)Session["productoseleccionado"];
            Producto seleccionado = listado.Find(x => x.Id == id);
            lblseleccionado.Text = seleccionado.CodigoArt;
            lblseleccionado1.Text = seleccionado.Nombre;
            lblseleccionado2.Text = seleccionado.Marca.Nombre;
            lblseleccionado3.Text = seleccionado.Descripcion;
            lblseleccionado4.Text = seleccionado.Categoria.Nombre;
            lblseleccionado5.Text = Convert.ToString(seleccionado.Precio);
            imgseleccionado.Src = seleccionado.UrlImagen;

        }
    }
}