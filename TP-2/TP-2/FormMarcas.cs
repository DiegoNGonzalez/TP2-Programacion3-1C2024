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
using dominio;

namespace TP_2
{
    public partial class FormMarcas : Form
    {
        public FormMarcas()
        {
            InitializeComponent();
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            Cargar();   
        }

        private void Cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                dgvMarcas.DataSource = negocio.ListarMarcas();
                dgvMarcas.Columns[0].Visible = false;
                dgvMarcas.Columns[1].HeaderText = "Marca";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMarca agregarMarca = new frmAgregarMarca();
            agregarMarca.ShowDialog();
            Cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validarSeleccion())
            {
                MessageBox.Show("Debe seleccionar una marca para modificar.");
                return;
            }
            Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmAgregarMarca modificar = new frmAgregarMarca(seleccionado);
            modificar.ShowDialog();
            
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar la marca seleccionada?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.No)
                {
                    return;
                }
                if (!validarSeleccion())
                {
                    MessageBox.Show("Debe seleccionar una marca para eliminar.");
                    return;
                }
                seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem; 
                negocio.eliminarMarca(seleccionado);
                Cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarSeleccion()
        {
            if (dgvMarcas.CurrentRow == null)
            {
                return false;
            }
            return true;
        }
    }
}
