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
using PresentationLayer.DetailPL;

namespace PresentationLayer.DetailPL
{
    public partial class DetailAdminWindow : Form
    {
        private DetailLogic detailLogic = new DetailLogic();
        public DetailAdminWindow()
        {
            InitializeComponent();
            DetailTable.DataSource = detailLogic.GetAll();
        }

        private void DetailAdminWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }

        private void AddDetail_Click(object sender, EventArgs e)
        {
            AddDetail f = new AddDetail();
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DetailTable.DataSource = detailLogic.GetAll();
        }

        private void RemoveDetail_Click(object sender, EventArgs e)
        {
            int id = (int)DetailTable.CurrentRow.Cells[0].Value;
            detailLogic.Remove(id);
        }
    }
}
