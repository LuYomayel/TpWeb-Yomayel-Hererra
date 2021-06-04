using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class Detalle : Form
    {
        public string ID { get; set; }
        public Detalle()
        {
            InitializeComponent();
        }
        //comentario
        private void label2_Click(object sender, EventArgs e)
        {

        }
         private void Detalle_Load(object sender, EventArgs e)
        {
            lblCodigo1.Text = ID;

            ProductoNegocio productoNegocio = new ProductoNegocio();
            Producto producto = new Producto();
            producto = productoNegocio.listarProducto(ID);
            lblNombre1.Text = producto.Nombre;
            lblDescripcion1.Text = producto.Descripcion;
            lblPrecio1.Text = Convert.ToString(producto.Precio);
            //cargarImagen(producto.UrlImagen);
            lblMarca1.Text = producto.Marca.Nombre;
            lblCategoria1.Text = producto.Categoria.Nombre;
            Convert.ToString(producto.Precio);
        }
       
        //public void cargarImagen(string img)
        //{
        //    try
        //    {
        //        pbxProducto.Load(img);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
    }
}
