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
    public partial class frmAgregarMarca : Form
    {
        private Marca marca = null;
        public frmAgregarMarca()
        {
            InitializeComponent();
        }
        public frmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validarTextBox()
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (marca == null) marca = new Marca();
                marca.NombreMarca = txtMarca.Text;

                if (marca.IDMarca != 0)
                {
                    if (!validarTextBox())
                    {
                        MessageBox.Show("Debe completar el campo Marca");
                        return;
                    }
                    negocio.modificarMarca(marca);
                    MessageBox.Show("Marca modificada con exito");
                }
                else
                {
                    if (!validarTextBox())
                    {
                        MessageBox.Show("Debe completar el campo Marca");
                        return;
                    }
                    negocio.agregarMarca(marca);
                    MessageBox.Show("Marca agregada con exito");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Close();
            }
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                txtMarca.Text = marca.NombreMarca;
            }
        }
    }
}
