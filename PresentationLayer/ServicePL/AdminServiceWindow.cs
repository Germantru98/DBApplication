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
    public partial class AdminServiceWindow : Form
    {
        private ServiceLogic serviceLogic = new ServiceLogic();
        public AdminServiceWindow()
        {
            InitializeComponent();
            ServiceTable.DataSource = serviceLogic.GetAll();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int id = (int)ServiceTable.CurrentRow.Cells[0].Value;
            serviceLogic.Remove(id);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddServiceForm f = new AddServiceForm();
            f.Show();
        }

        private void AdminServiceWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ServiceTable.DataSource = serviceLogic.GetAll();
        }
    }
}
