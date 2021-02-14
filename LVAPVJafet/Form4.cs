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
    public partial class frmAdopt : Form
    {
        public frmAdopt()
        {
            InitializeComponent();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            frmAdoptionResults frmAdoptionResults = new frmAdoptionResults();
            frmAdoptionResults.Show();
        }
    }
}
