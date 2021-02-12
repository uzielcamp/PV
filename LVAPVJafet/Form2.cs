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
    public partial class frmregistro : Form
    {
        public frmregistro()
        {
            InitializeComponent();
        }

        private void bttCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttInicio_Click(object sender, EventArgs e)
        {
            frmbusquedadeanimales frmbusquedadeanimales = new frmbusquedadeanimales();
            frmbusquedadeanimales.Show();

        }
    }
}
