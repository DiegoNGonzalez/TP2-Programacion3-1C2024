using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;

namespace TP_2
{
    public partial class FormArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public FormArticulos()
        {
            InitializeComponent();
        }


        private void FormArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.ListarArticulos();
            dgvArticulos.DataSource = listaArticulos;
            pBoxArticulosFormArticulos.Load(listaArticulos[0].Imagenes[0].URLImagen);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado =(Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.Imagenes[0].URLImagen);
        }

        private void CargarImagen(string imagen) 
        { 
            try
            {
                pBoxArticulosFormArticulos.Load(imagen); 
            } 
            catch (Exception ex)
            {
                pBoxArticulosFormArticulos.Load("https://i0.wp.com/static.vecteezy.com/system/resources/previews/005/337/799/original/icon-image-not-found-free-vector.jpg?ssl=1");
            }
        }
    }
}
