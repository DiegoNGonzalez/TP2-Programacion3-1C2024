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
        private Imagen imagen = new Imagen();
        
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
            Imagen seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
            pBoxAbmImagenes.Load(seleccionado.URLImagen);
            txtUrlImagen.Text = imagenes[dgvImagenes.CurrentRow.Index].URLImagen;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //FormAddModImg form = new FormAddModImg();
            //form.ShowDialog();
            if (txtUrlImagen.Text == "")
            {
                MessageBox.Show("Debe ingresar una URL de imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if (txtUrlImagen.Text.Length < 10)
            {
                MessageBox.Show("La URL de la imagen es muy corta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                imagen.IDArticulo = Articulo.IDArticulo;
                imagen.URLImagen = txtUrlImagen.Text;
                imagenes.Add(imagen);
                datos.SetearConsulta("insert into IMAGENES (IdArticulo, ImagenUrl) values (@IdArticulo, @ImagenUrl)");
                datos.SetearParametro("@IdArticulo", imagen.IDArticulo);
                datos.SetearParametro("@ImagenUrl", imagen.URLImagen);
                datos.EjecutarAccion();
                dgvImagenes.DataSource = null;
                dgvImagenes.DataSource = imagenes;
                dgvImagenes.Columns[0].Visible = false;
                datos.CerrarConexion();
                txtUrlImagen.Text = "";
                MessageBox.Show("Imagen agregada con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUrlImagen.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtUrlImagen.Text == "")
            {
                MessageBox.Show("Debe ingresar una URL de imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtUrlImagen.Text.Length < 10)
            {
                MessageBox.Show("La URL de la imagen es muy corta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                datos.SetearConsulta("update IMAGENES set ImagenUrl = @URL where Id = @ID");
                datos.SetearParametro("@URL", txtUrlImagen.Text);
                datos.SetearParametro("@ID", imagenes[dgvImagenes.CurrentRow.Index].IDImagen);
                datos.EjecutarAccion();
                imagenes[dgvImagenes.CurrentRow.Index].URLImagen = txtUrlImagen.Text;
                dgvImagenes.DataSource = null;
                dgvImagenes.DataSource = imagenes;
                dgvImagenes.Columns[0].Visible = false;
                datos.CerrarConexion();
                MessageBox.Show("Imagen modificada con exito", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(imagenes.Count <= 2)
            {
                MessageBox.Show(text: "Tiene que tener al menos 2 imagenes para poder eliminar","Reintente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                imagen = imagenes[dgvImagenes.CurrentRow.Index];
                datos.SetearConsulta("delete from IMAGENES where Id = @ID");
                datos.SetearParametro("@ID", imagenes[dgvImagenes.CurrentRow.Index].IDImagen);
                datos.EjecutarAccion();
                imagenes.Remove(imagen);
                datos.CerrarConexion();
                MessageBox.Show("Imagen eliminada con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pBoxAbmImagenes.Load(imagenes[0].URLImagen);
            }
            dgvImagenes.DataSource = imagenes;
            dgvImagenes.Columns[0].Visible = false;

        }
    }
}
