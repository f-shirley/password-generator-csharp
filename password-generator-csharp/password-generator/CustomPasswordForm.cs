using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace password_generator
{
    public partial class CustomPasswordForm : Form
    {
        public CustomPasswordForm()
        {
            InitializeComponent();
        }

        private void CustomPasswordForm_Load(object sender, EventArgs e)
        {
            
        }

        //on click, creates a password based on the supplied word and # symbols using createRandomChar method
        private void btn_CustomCreate_Click(object sender, EventArgs e)
        {
            string selection = txtbox_CustomPasswordEntry.Text;
            string newpassword = "";
            RandomPasswordForm randompasswordform = new RandomPasswordForm();

            foreach (char letter in selection)
            {
                if(letter != '#')
                {
                    newpassword += letter;
                }
                else if(letter == '#')
                {
                    newpassword += randompasswordform.createRandomChar();
                }
            }

            txtbox_CustomPassword.Text = newpassword;
        }
    }
}
