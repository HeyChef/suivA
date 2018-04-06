using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suivA
{
    public partial class visiteurAccueil : Form
    {
        public visiteurAccueil()
        {
            InitializeComponent();
        }

        private void visiteurAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addVisite_Click(object sender, EventArgs e)
        {
            AddVisite addVisiteWindow = new AddVisite();
            addVisiteWindow.Show();
        }
    }
}
