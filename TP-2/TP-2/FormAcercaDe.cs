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
    public partial class FormAcercaDe : Form
    {
        public FormAcercaDe()
        {
            InitializeComponent();
        }

       

        private void btnGitHubDiego_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DiegoNGonzalez");
        }

        private void btnLinkedinDiego_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/diegongonzalez/");
        }

        private void btnLinkedinTomi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/cacerestomas/");
        }

        private void btnGithubTomi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tomyok");
        }

        private void btnGithubSeba_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sebastian-scollo");
        }

        private void btnLinkedinSeba_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/sebas-scollo-793b8324a/");
        }
    }
}
