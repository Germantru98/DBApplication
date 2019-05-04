using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AdminUserForm : Form
    {
        public AdminUserForm()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "Admin" && PasswordTextBox.Text == "admin")
            {
                Hide();
                AdminForm form = new AdminForm();
                form.Show();
            }
            else if (LoginTextBox.Text == "User" && PasswordTextBox.Text == "user")
            {
                Hide();
                UserForm form = new UserForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void AdminUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void AdminUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
