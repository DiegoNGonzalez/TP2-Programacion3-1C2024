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
        }
        public FormAddMod(Articulo Articulo)
        {
            InitializeComponent();
            this.Articulo = Articulo;
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
            nudPrecioFormAddMod.Increment = 0.01m;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (Articulo == null)
                    Articulo= CapturarArticuloForm();
                negocio.AgregarArticulo(Articulo);
                MessageBox.Show("Articulo agregado con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
