﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322_AA_1210924
{
    public partial class Check_form : Form
    {
        public Check_form()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (chkCoffee.Checked == true)
            {
                msg = chkCoffee.Text;
            }

            if (chkDonut.Checked == true)
            {
                msg = msg + " " + chkDonut.Text;
            }

            if (chkBrownie.Checked == true)
            {
                msg = msg + " " + chkBrownie.Text;
            }

            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " Selected ");
            }
            else //length is zero
            {
                MessageBox.Show("Nothing Selected");
            }

        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Check_form_Load(object sender, EventArgs e)
        {

        }
    }
}
