using System;
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
    public partial class Picture_form : Form
    {
        public Picture_form()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                picTry.Image = Image.FromFile(""); 

            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Picture_form_Load(object sender, EventArgs e)
        {

        }

        private void PicTry_Click(object sender, EventArgs e)
        {

        }
    }
}
