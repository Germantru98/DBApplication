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

namespace PresentationLayer.ClientPL
{
    public partial class ClientAdminForm : Form
    {
        private ClientLogic clientLogic = new ClientLogic();
        public ClientAdminForm()
        {
            InitializeComponent();
            ClientTable.DataSource = clientLogic.GetAll();

        }

        private void RemoveClient_Click(object sender, EventArgs e)
        {
            int id = (int)ClientTable.CurrentRow.Cells[0].Value;
            clientLogic.Remove(id);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClientTable.DataSource = clientLogic.GetAll();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            AddClientForm f = new AddClientForm();
            f.Show();
        }

        private void ClientAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }


    }
}
