using dominio;
using Negocio;
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
    public partial class FormAddCategoria : Form
    {
        private Categoria cat = null;
        public FormAddCategoria()
        {
            InitializeComponent();
        }

        public FormAddCategoria(Categoria categoria)
        {
            InitializeComponent();
            cat = categoria;
            Text = "Modificar";
        }

        private void btnAceptarAddCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio nego = new CategoriaNegocio();
            try
            {
                if (cat == null) cat = new Categoria();

                cat.NombreCategoria = txtbAddCategoria.Text;

                if(cat.IDCategoria!=0)
                {
                    nego.modificarCategoria(cat);
                    MessageBox.Show("Categoria Modificada Exitosamente.");
                }
                else
                {
                    nego.agregarCategoria(cat);
                    MessageBox.Show("Categoria Agregada Exitosamente.");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Close();
            }
        }

        private void btnCancelarAddCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
