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
using AccesoDataBase;

namespace TP_2
{
    public partial class FormAbmImagenes : Form
    {
        private Articulo Articulo;
        private List<Imagen> imagenes;
        private AccesoDatos datos = new AccesoDatos();
        
        public FormAbmImagenes()
        {
            InitializeComponent();
        }
        public FormAbmImagenes(Articulo articulo)
        {
            Articulo = articulo;
            imagenes = articulo.Imagenes;
            InitializeComponent();
            
            pBoxAbmImagenes.Load(imagenes[0].URLImagen);
        }

        private void FormAbmImagenes_Load(object sender, EventArgs e)
        {
            dgvImagenes.DataSource = imagenes;
            dgvImagenes.Columns[0].Visible = false;

        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            pBoxAbmImagenes.Load(imagenes[dgvImagenes.CurrentRow.Index].URLImagen);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAddModImg form = new FormAddModImg();
            form.ShowDialog();
        }
    }
}
