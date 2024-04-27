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
        public formDetalles()
        {
            InitializeComponent();
        }
        public formDetalles(Articulo articulo)
        {
            InitializeComponent();
            lblNombreArticulo.Text = articulo.NombreArticulo;
            lblValorCodigo.Text = articulo.CodigoArticulo;
            lblValorDescripcion.Text = articulo.DescripcionArticulo;
            lblValorMarca.Text = articulo.MarcaArticulo.NombreMarca;
            lblValorCategoria.Text = articulo.CategoriaArticulo.NombreCategoria;
            lblValorPrecio.Text = articulo.PrecioArticulo.ToString("0.00");
            pbxDetallles.Load(articulo.Imagenes[0].URLImagen);


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
