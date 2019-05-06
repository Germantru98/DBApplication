using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLogic;

namespace PresentationLayer.ServicePL
{
    public partial class AddServiceForm : Form
    {
        private ServiceLogic serviceLogic = new ServiceLogic();
        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            serviceLogic.Add(new Service(textBox1.Text, decimal.Parse(textBox2.Text)));
            Close();
        }

        private void AddServiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminServiceWindow w = new AdminServiceWindow();
            w.Show();
        }
    }
}
