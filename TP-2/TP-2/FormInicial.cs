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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            FormArticulos formArticulos = new FormArticulos();
            formArticulos.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FormMarcas formMarca = new FormMarcas();
            formMarca.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormCategorias formCategorias = new FormCategorias();
            formCategorias.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAcercaDe formAcercade = new FormAcercaDe(); 
            formAcercade.ShowDialog();
        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.LightGray;
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.FromArgb(23,23,23);
        }
    }
}
