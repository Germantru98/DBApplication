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

namespace PresentationLayer.ListOfServicePL
{
    public partial class AddLoS : Form
    {
        private ContractLogic contractLogic = new ContractLogic();
        private ServiceLogic serviceLogic = new ServiceLogic();
        private ListOfServiceLogic listOfServiceLogic = new ListOfServiceLogic();
        public AddLoS()
        {
            InitializeComponent();
            ContractCbox.DataSource = contractLogic.GetAll();
            ServiceCBox.DataSource = serviceLogic.GetAll();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Contract c = (Contract)ContractCbox.SelectedItem;
            Service s = (Service)ServiceCBox.SelectedItem;
            listOfServiceLogic.Add(new ListOfService(c.ID, s.ID));
            Hide();
        }
    }
}
