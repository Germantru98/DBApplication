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
using PresentationLayer.ListOfDetailPL;
using BusinessLogic;

namespace PresentationLayer.ListOfDetailPL
{
    public partial class AdminListOfDetailWindow : Form
    {
        private ListOfDetailLogic logic = new ListOfDetailLogic();
        public AdminListOfDetailWindow()
        {
            InitializeComponent();
            LoDTable.DataSource = logic.GetAll();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddLoDForm f = new AddLoDForm();
            f.Show();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int id = (int)LoDTable.CurrentRow.Cells[0].Value;
            logic.Remove(id);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LoDTable.DataSource = logic.GetAll();
        }

        private void AdminListOfDetailWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }
    }
}
