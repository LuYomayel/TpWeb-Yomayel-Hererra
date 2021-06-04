using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class FrmProducto : Form
    {
        private Producto producto;
        public FrmProducto()
        {
            InitializeComponent();
        }
        public FrmProducto(Producto nuevo)
        {
            InitializeComponent();
            producto = nuevo;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio CategoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Nombre";

                cboCategoria.DataSource = CategoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Nombre";
                
                if (producto != null)
                {
                    txtCodigo.Text = producto.CodigoArt;
                    txtNombre.Text = producto.Nombre;
                    txtDescripcion.Text = producto.Descripcion;
                    txtUrlImagen.Text = producto.UrlImagen;
                    cargarImagen(producto.UrlImagen);
                    numPrecio.Value = producto.Precio;
                    cboMarca.SelectedValue = producto.Marca.Id;
                    cboCategoria.SelectedValue = producto.Categoria.Id;
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void cargarImagen(string img)
        {
            try
            {
                pbxProducto.Load(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();

            try
            {
                if (producto == null) producto = new Producto();

                producto.CodigoArt = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.UrlImagen = txtUrlImagen.Text;
                producto.Marca = (Marca)cboMarca.SelectedItem;
                producto.Categoria = (Categoria)cboCategoria.SelectedItem;
                producto.Precio = numPrecio.Value;
                productoNegocio.modificar(producto);

                if(producto.Id == 0)
                {
                    productoNegocio.agregar(producto);
                    MessageBox.Show("agregado sin problema");
                }
                else
                {
                    productoNegocio.modificar(producto);
                    MessageBox.Show("modificado sin problema");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
