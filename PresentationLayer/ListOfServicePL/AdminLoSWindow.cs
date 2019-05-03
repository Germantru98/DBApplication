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
using PresentationLayer.ListOfServicePL;
using BusinessLogic;

namespace PresentationLayer.ListOfServicePL
{
    public partial class AdminLoSWindow : Form
    {
        private ListOfServiceLogic logic = new ListOfServiceLogic();
        public AdminLoSWindow()
        {
            InitializeComponent();
            LoSTable.DataSource = logic.GetAll();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LoSTable.DataSource = logic.GetAll();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int id = (int)LoSTable.CurrentRow.Cells[0].Value;
            logic.Remove(id);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddLoS f = new AddLoS();
            f.Show();
        }

        private void AdminLoSWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }
    }
}
