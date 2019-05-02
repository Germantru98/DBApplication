using System;
using System.Windows.Forms;
using BusinessLogic;
using PresentationLayer.SpecialistPL;

namespace PresentationLayer.SpecialistPL
{
    public partial class AdminSpecialistForm : Form
    {
        private SpecialistLogic specialistLogic = new SpecialistLogic();
        public AdminSpecialistForm()
        {
            InitializeComponent();
            SpecialistTable.DataSource = specialistLogic.GetAll();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddSpecialistForm f = new AddSpecialistForm();
            f.Show();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int id = (int)SpecialistTable.CurrentRow.Cells[0].Value;
            specialistLogic.Remove(id);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SpecialistTable.DataSource = specialistLogic.GetAll();
        }

        private void AdminSpecialistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }
    }
}
