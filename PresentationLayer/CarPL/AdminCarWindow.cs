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
using PresentationLayer.CarPL;

namespace PresentationLayer.CarPL
{
    public partial class AdminCarWindow : Form
    {
        private CarLogic carLogic = new CarLogic();
        public AdminCarWindow()
        {
            InitializeComponent();
            CarTable.DataSource = carLogic.GetAll();
        }

        private void AdminCarWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCarForm f = new AddCarForm();
            f.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            CarTable.DataSource = carLogic.GetAll();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int id = (int)CarTable.CurrentRow.Cells[0].Value;
            carLogic.Remove(id);
        }
    }
}
