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
    public partial class FormAddMod : Form
    {
        public FormAddMod()
        {
            InitializeComponent();
        }

        private void FormAddMod_Load(object sender, EventArgs e)
        {
            nudPrecioFormAddMod.DecimalPlaces = 2;
            nudPrecioFormAddMod.Minimum = 0.00m;
            nudPrecioFormAddMod.Maximum = 999999.99m;
            nudPrecioFormAddMod.Increment = 0.01m;

        }
    }
}
