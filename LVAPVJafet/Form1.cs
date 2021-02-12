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
    public partial class frmbusquedadeanimales : Form
    {
        public frmbusquedadeanimales()
        {
            InitializeComponent();
        }

        private void bttAbrirfrm2_Click(object sender, EventArgs e)
        {
            frmregistro frm2 = new frmregistro();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmbusquedadeanimales_Load(object sender, EventArgs e)
        {

        }
    }
}
