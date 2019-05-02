using System;
using System.Windows.Forms;
using PresentationLayer.DetailPL;
using PresentationLayer.ServicePL;
using PresentationLayer.SpecialistPL;
using PresentationLayer.PaymentPL;
using PresentationLayer.CarPL;

namespace PresentationLayer
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void MarkButton_Click(object sender, EventArgs e)
        {
            Hide();
            MarkAdminWindow f = new MarkAdminWindow();
            f.Show();
        }
        

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminUserForm f = new AdminUserForm();
            f.Show();
        }

        private void DetailButton_Click(object sender, EventArgs e)
        {
            DetailAdminWindow w = new DetailAdminWindow();
            Hide();
            w.Show();
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            AdminServiceWindow w = new AdminServiceWindow();
            Hide();
            w.Show();
        }

        private void SpecialistButton_Click(object sender, EventArgs e)
        {
            AdminSpecialistForm f = new AdminSpecialistForm();
            Hide();
            f.Show();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            PaymentAdminWindow w = new PaymentAdminWindow();
            Hide();
            w.Show();
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            AdminCarWindow w = new AdminCarWindow();
            Hide();
            w.Show();
        }
    }
}
