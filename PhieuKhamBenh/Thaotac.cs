﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhieuKhamBenh
{
    public partial class Thaotac : Form
    {
        public Thaotac()
        {
            InitializeComponent();
        }

        private void BtnTaophieumoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuKhamBenh pkb = new PhieuKhamBenh();
            pkb.Show();
        }
    }
}
