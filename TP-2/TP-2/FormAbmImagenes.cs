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
using Negocio;

namespace TP_2
{
    public partial class FormAbmImagenes : Form
    {
        private Articulo Articulo;
        private List<Imagen> imagenes;
        private AccesoDatos datos = new AccesoDatos();
        private Imagen imagen = new Imagen();
        private ImagenNegocio negocio = new ImagenNegocio();
        
        public FormAbmImagenes()
        {
            InitializeComponent();
        }
        public FormAbmImagenes(Articulo articulo)
        {
            Articulo = articulo;
            imagenes = negocio.Listarimagenes(Articulo.IDArticulo);
            
            InitializeComponent();
            
        }

        private void FormAbmImagenes_Load(object sender, EventArgs e)
        {
            dgvImagenes.DataSource = imagenes;
            dgvImagenes.Columns[0].Visible = false;
            pBoxAbmImagenes.Load(imagenes[0].URLImagen);

        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                pBoxAbmImagenes.Load(imagenes[dgvImagenes.CurrentRow.Index].URLImagen);
                txtUrlImagen.Text = imagenes[dgvImagenes.CurrentRow.Index].URLImagen;

            }
            catch (Exception)
            {
                pBoxAbmImagenes.Load(imagenes[0].URLImagen);
            }
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
                imagenes = negocio.Listarimagenes(Articulo.IDArticulo);
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
            else if (txtUrlImagen.Text.Length <10)
            {
                MessageBox.Show("La URL de la imagen es muy corta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(MessageBox.Show("¿Esta seguro que desea modificar la imagen?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.No)
                {
                    return;
                }
                else
                {
                    datos.SetearConsulta("update IMAGENES set ImagenUrl = @URL where Id = @ID");
                    datos.SetearParametro("@URL", txtUrlImagen.Text);
                    datos.SetearParametro("@ID", imagenes[dgvImagenes.CurrentRow.Index].IDImagen);
                    datos.EjecutarAccion();
                    imagenes[dgvImagenes.CurrentRow.Index].URLImagen = txtUrlImagen.Text;
                    imagenes = negocio.Listarimagenes(Articulo.IDArticulo);
                    dgvImagenes.DataSource = imagenes;
                    dgvImagenes.Columns[0].Visible = false;
                    datos.CerrarConexion();
                    MessageBox.Show("Imagen modificada con exito", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }



            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (imagenes.Count <= 1)
            {
                MessageBox.Show("El articulo no puede quedar sin imagenes, antes de eliminar agregue otra", "Reintentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            {
                if (dgvImagenes.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dgvImagenes.CurrentRow.Index == -1)
                {
                    MessageBox.Show("Debe seleccionar una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("¿Esta seguro que desea eliminar la imagen?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    imagen = imagenes[dgvImagenes.CurrentRow.Index];
                    datos.SetearConsulta("delete from IMAGENES where Id = @ID");
                    datos.SetearParametro("@ID", imagenes[dgvImagenes.CurrentRow.Index].IDImagen);
                    datos.EjecutarAccion();
                    //imagenes.Remove(imagen);
                    datos.CerrarConexion();
                    imagenes = negocio.Listarimagenes(Articulo.IDArticulo);
                    MessageBox.Show("Imagen eliminada con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvImagenes.DataSource = imagenes;
                    dgvImagenes.Columns[0].Visible = false;

                }

    
            }
                
            

        }
    }
}
