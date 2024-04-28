using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2
{
    public partial class formDetalles : Form
    {
        private Articulo seleccionado;
        public formDetalles()
        {
            InitializeComponent();
        }
        public formDetalles(Articulo articulo)
        {
            seleccionado = articulo;
            InitializeComponent();
            lblNombreArticulo.Text = articulo.NombreArticulo;
            lblValorCodigo.Text = articulo.CodigoArticulo;
            lblValorDescripcion.Text = articulo.DescripcionArticulo;
            lblValorMarca.Text = articulo.MarcaArticulo.NombreMarca;
            lblValorCategoria.Text = articulo.CategoriaArticulo.NombreCategoria;
            lblValorPrecio.Text = articulo.PrecioArticulo.ToString("$0.00");
            pbxDetallles.Load(articulo.Imagenes[0].URLImagen);


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnAnteriorImg_Click(object sender, EventArgs e)
        {
            int index = seleccionado.Imagenes.IndexOf(seleccionado.Imagenes.Find(x => x.URLImagen == pbxDetallles.ImageLocation));
            if (index == 0)
            {
                index = seleccionado.Imagenes.Count - 1;
            }
            else
            {
                index--;
            }
            CargarImagen(seleccionado.Imagenes[index].URLImagen);
        }

        private void btnSiguienteImg_Click(object sender, EventArgs e)
        {
           
            int index = seleccionado.Imagenes.IndexOf(seleccionado.Imagenes.Find(x => x.URLImagen == pbxDetallles.ImageLocation));
            if (index == seleccionado.Imagenes.Count - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            CargarImagen(seleccionado.Imagenes[index].URLImagen);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbxDetallles.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxDetallles.Load("https://i0.wp.com/static.vecteezy.com/system/resources/previews/005/337/799/original/icon-image-not-found-free-vector.jpg?ssl=1");
            }
        }
    }
}
