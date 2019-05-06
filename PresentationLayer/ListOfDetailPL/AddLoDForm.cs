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
using PresentationLayer.ListOfDetailPL;

namespace PresentationLayer.ListOfDetailPL
{
    public partial class AddLoDForm : Form
    {
        private ContractLogic contractLogic = new ContractLogic();
        private DetailLogic detailLogic = new DetailLogic();
        private ListOfDetailLogic logic = new ListOfDetailLogic();

        public AddLoDForm()
        {
            InitializeComponent();
            ContractCBox.DataSource = contractLogic.GetAll();
            DetailCBox.DataSource =  detailLogic.GetAll();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Contract c = (Contract)ContractCBox.SelectedItem;
            Detail d = (Detail)DetailCBox.SelectedItem;
            logic.Add(new ListOfDetail(c.ID, d.ID));
            Close();
        }
    }
}
