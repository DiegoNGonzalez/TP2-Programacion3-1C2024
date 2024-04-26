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
        private ArticuloNegocio negocio = new ArticuloNegocio();
        public FormArticulos()
        {
            InitializeComponent();
            negocio = new ArticuloNegocio();
        }


        private void FormArticulos_Load(object sender, EventArgs e)
        {
            
            CargarGrid();
        }
        private void CargarGrid()
        {
            try
            {
                listaArticulos = negocio.ListarArticulos();
                dgvArticulos.DataSource = listaArticulos;
                pBoxArticulosFormArticulos.Load(listaArticulos[0].Imagenes[0].URLImagen);
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

        private void btnAgregarFormArticulos_Click(object sender, EventArgs e)
        {
            FormAddMod formAddMod = new FormAddMod();
            formAddMod.ShowDialog();
            CargarGrid();
            
        }

        private void btnModificarFormArticulos_Click(object sender, EventArgs e)
        {
            FormAddMod formAddMod = new FormAddMod();
            formAddMod.ShowDialog();
            CargarGrid();
        }

        private void btnEliminarFormArticulos_Click(object sender, EventArgs e)
        {
            
            Articulo artSelec;
            try
            {
                DialogResult rta = MessageBox.Show("¿Esta seguro que desea eliminar este articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rta == DialogResult.No)
                {
                    return;
                }
                artSelec = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                negocio.EliminarArticulo(artSelec.IDArticulo);
                CargarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSiguienteImg_Click(object sender, EventArgs e)
        {
            Articulo selecciondo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int index = selecciondo.Imagenes.IndexOf(selecciondo.Imagenes.Find(x => x.URLImagen == pBoxArticulosFormArticulos.ImageLocation));
            if (index == selecciondo.Imagenes.Count - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            CargarImagen(selecciondo.Imagenes[index].URLImagen);
        }

        private void btnAnteriorImg_Click(object sender, EventArgs e)
        {
            Articulo selecciondo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int index = selecciondo.Imagenes.IndexOf(selecciondo.Imagenes.Find(x => x.URLImagen == pBoxArticulosFormArticulos.ImageLocation));
            if (index == 0)
            {
                index = selecciondo.Imagenes.Count - 1;
            }
            else
            {
                index--;
            }
            CargarImagen(selecciondo.Imagenes[index].URLImagen);
        }
    }
}
