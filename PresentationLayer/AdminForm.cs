using System;
using System.Windows.Forms;
using PresentationLayer.DetailPL;
using PresentationLayer.ServicePL;
using PresentationLayer.SpecialistPL;
using PresentationLayer.PaymentPL;
using PresentationLayer.CarPL;
using PresentationLayer.ContractPL;
using PresentationLayer.ListOfServicePL;
using PresentationLayer.ListOfDetailPL;
using PresentationLayer.AdminFunc;

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

        private void ContractButton_Click(object sender, EventArgs e)
        {
            ContractAdminWindow w = new ContractAdminWindow();
            Hide();
            w.Show();
        }

        private void ListofServicesButton_Click(object sender, EventArgs e)
        {
            AdminLoSWindow w = new AdminLoSWindow();
            Hide();
            w.Show();
        }

        private void ListofDetailButton_Click(object sender, EventArgs e)
        {
            AdminListOfDetailWindow w = new AdminListOfDetailWindow();
            Hide();
            w.Show();
        }

        private void OnlyDetailPrice_Click(object sender, EventArgs e)
        {
            CalcDetailPriceForm f = new CalcDetailPriceForm();
            Hide();
            f.Show();
        }

        private void TotalServicesPriceButton_Click(object sender, EventArgs e)
        {
            CalcServicePriceForm f = new CalcServicePriceForm();
            Hide();
            f.Show();
        }
    }
}
