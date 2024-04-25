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
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }
        private void Cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                dgvCategorias.DataSource = negocio.listarCategorias();
                dgvCategorias.Columns[0].Visible = false;
                dgvCategorias.Columns[1].HeaderText = "Categoria";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAddCategoria form = new FormAddCategoria();
            form.ShowDialog();
            Cargar(); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria catSelec = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            FormAddCategoria form = new FormAddCategoria(catSelec);
            form.ShowDialog();
            Cargar();

        }
    }
}
