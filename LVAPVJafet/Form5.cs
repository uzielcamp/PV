﻿using System;
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
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbPetname_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {

        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            frmSearchResults frmSearchResults = new frmSearchResults();
            frmSearchResults.Show();
        }
    }
}
