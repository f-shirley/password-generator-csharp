using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generator
{
    public partial class PasswordGeneratorForm : Form
    {
        public PasswordGeneratorForm()
        {
            InitializeComponent();
            //created by Franklin
            //v1.0.0
            //1.12.2023

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_CustomPassword_Click(object sender, EventArgs e)
        {
            CustomPasswordForm custompasswordform = new CustomPasswordForm();
            custompasswordform.Show();
        }

        private void btn_RandomPassword_Click(object sender, EventArgs e)
        {
            RandomPasswordForm randompasswordform = new RandomPasswordForm();
            randompasswordform.Show();
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }
    }
}
