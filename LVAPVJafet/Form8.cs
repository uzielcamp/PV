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
    public partial class frmAdoptionRequest : Form
    {
        public frmAdoptionRequest()
        {
            InitializeComponent();
        }

        private void frmAdoptionRequest_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void lblPickUpDay_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (prgSave.Value < 100)
                prgSave.Value = prgSave.Value + 10;
            else
                prgSave.Value = prgSave.Value - 100;
        }
    }
}
