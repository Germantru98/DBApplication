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
using PresentationLayer.ContractPL;

namespace PresentationLayer.ContractPL
{
    public partial class ContractAdminWindow : Form
    {
        private ContractLogic contractLogic = new ContractLogic();
        public ContractAdminWindow()
        {
            InitializeComponent();
            ContractTable.DataSource = contractLogic.GetAll();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int id = (int)ContractTable.CurrentRow.Cells[0].Value;
            contractLogic.Remove(id);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ContractTable.DataSource = contractLogic.GetAll();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddContractForm f = new AddContractForm();
            f.Show();
        }

        private void ContractAdminWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }
    }
}
