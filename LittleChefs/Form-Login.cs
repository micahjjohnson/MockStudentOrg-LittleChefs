using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleChefs
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to exit?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Login.Validation login = new Login.Validation(Resources.littleChefs.getAccountList());
            switch (login.attempt(usernameTB.Text, passwordTB.Text))
            {
                case 0:
                    MessageBox.Show("No user by that name. Try again.");
                    usernameTB.Clear();
                    usernameTB.Focus();
                    break;
                case 1:
                    this.Hide();
                    var form = new Form1();
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                    break;
                case 2:
                    MessageBox.Show("LOCKED.");
                    break;
                case 3:
                    MessageBox.Show("Wrong Password");
                    passwordTB.Focus();
                    break;
                case 4:
                    MessageBox.Show("Please enter valid information.");
                    break;

            }
            passwordTB.Clear();
        }
    }
}