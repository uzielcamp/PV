using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVAPVJafet
{
    public partial class frmstartingscreen : Form
    {
        public frmstartingscreen()
        {
            InitializeComponent();
        }

        private void bttAdopt_Click(object sender, EventArgs e)
        {
            frmAdopt frmAdopt = new frmAdopt();
            frmAdopt.Show();

        }
    }
}
