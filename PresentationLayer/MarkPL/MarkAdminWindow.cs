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
using PresentationLayer.MarkPL;
using PresentationLayer;

namespace PresentationLayer
{
    public partial class MarkAdminWindow : Form
    {
        private MarkLogic markLogic = new MarkLogic();
        public MarkAdminWindow()
        {

            InitializeComponent();
            MarkTable.DataSource = markLogic.GetAll();
        }

        private void MarkAdminWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }

        private void AddMark_Click(object sender, EventArgs e)
        {
            AddMarkForm f = new AddMarkForm();
            f.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MarkTable.DataSource = markLogic.GetAll();
        }

        private void RemoveMark_Click(object sender, EventArgs e)
        {
            int id = (int)MarkTable.CurrentRow.Cells[0].Value;
            markLogic.Remove(id);
        }

        private void MarkTable_DataSourceChanged(object sender, EventArgs e)
        {
            
        }
    }
}
