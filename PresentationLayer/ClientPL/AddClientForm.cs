using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Entities;

namespace PresentationLayer.ClientPL
{
    public partial class AddClientForm : Form
    {
        private ClientLogic clientLogic = new ClientLogic();
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            clientLogic.Add(new Client(NameBox.Text, SecondNameBox.Text, NumberBox.Text, PassportBox.Text, AddresBox.Text));
            Hide();
        }
    }
}
