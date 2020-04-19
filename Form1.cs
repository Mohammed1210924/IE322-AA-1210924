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
    public partial class Form1 : Form
    {
        string Username = "Moh"; 
        string MyPassword = "123"; 
        bool loggedIn = false;

        int attempt = 1;
        int MaxAttempts = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (!loggedIn)
            {

                while (attempt <= MaxAttempts)
                {
                    if (txtUser.Text != Username)
                    {
                        
                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        return;
                    }
                    else
                    {   			
                        if (txtPassword.Text != MyPassword)
                        {
                           
                            attempt++;
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            return;
                        }
                    }
                }
            }
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            Radio_form frm = new Radio_form();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Check_form frm = new Check_form();
            frm.ShowDialog();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            Combo_form1 frm = new Combo_form1();
            frm.ShowDialog();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            Picture_form frm = new Picture_form();
            frm.ShowDialog();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random_form frm = new Random_form();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandomC_form frm = new RandomC_form();
            frm.ShowDialog();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GrpLogin_Enter(object sender, EventArgs e)
        {

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.21.5");
        }

        private void LblUsername_Click(object sender, EventArgs e)
        {

        }
    }

                        
}
