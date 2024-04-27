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
    public partial class FormAddMod : Form
    {
        private Articulo Articulo=null;
        private AccesoDatos Datos = new AccesoDatos();
        public FormAddMod()
        {
            InitializeComponent();
            btnAbmImagenes.Visible = false;
        }
        public FormAddMod(Articulo Articulo)
        {
            InitializeComponent();
            this.Articulo = Articulo;
            Text = "Modificar";
            lblUrlImgFormAddMod.Text = "Imagenes";
            txtUrlFormAddMod.Visible = false;
            btnAbmImagenes.Location = new Point(206, 182);
        }

        public Articulo CapturarArticuloForm()
        {
            try
            {
                if (Articulo == null)
                    Articulo = new Articulo();
                
                Articulo.CodigoArticulo = txtCodigoFormAddMod.Text;
                Articulo.NombreArticulo = txtNombreFormAddMod.Text;
                Articulo.DescripcionArticulo = txtDescripcionFormAddMod.Text;
                Articulo.PrecioArticulo = nudPrecioFormAddMod.Value;
                Articulo.MarcaArticulo = (Marca)cbxMarcaFormAddMod.SelectedItem;
                Articulo.CategoriaArticulo = (Categoria)cbxCategoriaFormAddMod.SelectedItem;
                Articulo.Imagenes = new List<Imagen>();
                Articulo.Imagenes.Add(new Imagen() { URLImagen = txtUrlFormAddMod.Text });


                return Articulo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void FormAddMod_Load(object sender, EventArgs e)
        {
            nudPrecioFormAddMod.DecimalPlaces = 2;
            nudPrecioFormAddMod.Minimum = 0.00m;
            nudPrecioFormAddMod.Maximum = 999999.99m;
            nudPrecioFormAddMod.Increment = 1.00m;
            CategoriaNegocio negocio = new CategoriaNegocio();
            MarcaNegocio negocioMarca = new MarcaNegocio();
            try
            {
                cbxCategoriaFormAddMod.DataSource = negocio.listarCategorias();
                cbxCategoriaFormAddMod.ValueMember = "IDCategoria";
                cbxCategoriaFormAddMod.DisplayMember = "NombreCategoria";
                cbxMarcaFormAddMod.DataSource = negocioMarca.ListarMarcas();
                cbxMarcaFormAddMod.ValueMember = "IDMarca";
                cbxMarcaFormAddMod.DisplayMember = "NombreMarca";

                if (Articulo != null)
                {
                    txtCodigoFormAddMod.Text = Articulo.CodigoArticulo;
                    txtNombreFormAddMod.Text = Articulo.NombreArticulo;
                    txtDescripcionFormAddMod.Text = Articulo.DescripcionArticulo;
                    nudPrecioFormAddMod.Value = Articulo.PrecioArticulo;
                    cbxCategoriaFormAddMod.SelectedValue = Articulo.CategoriaArticulo.IDCategoria;
                    cbxMarcaFormAddMod.SelectedValue = Articulo.MarcaArticulo.IDMarca;
                    txtUrlFormAddMod.Text = Articulo.Imagenes[0].URLImagen;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (Articulo == null)
                    Articulo= CapturarArticuloForm();
                if (Articulo.IDArticulo != 0)
                {
                    Articulo.CodigoArticulo = txtCodigoFormAddMod.Text;
                    Articulo.NombreArticulo = txtNombreFormAddMod.Text;
                    Articulo.DescripcionArticulo = txtDescripcionFormAddMod.Text;
                    Articulo.PrecioArticulo = nudPrecioFormAddMod.Value;
                    Articulo.MarcaArticulo = (Marca)cbxMarcaFormAddMod.SelectedItem;
                    Articulo.CategoriaArticulo = (Categoria)cbxCategoriaFormAddMod.SelectedItem;
                    Articulo.Imagenes = new List<Imagen>();
                    Articulo.Imagenes.Add(new Imagen() { URLImagen = txtUrlFormAddMod.Text });
                    negocio.ModificarArticulo(Articulo);
                    MessageBox.Show("Articulo modificado con exito");
                }
                else
                {

                    negocio.AgregarArticulo(Articulo);
                    MessageBox.Show("Articulo agregado con exito");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbmImagenes_Click(object sender, EventArgs e)
        {
            FormAbmImagenes form = new FormAbmImagenes(Articulo);
            form.ShowDialog();
        }
    }
}
