using System;
using System.Windows.Forms;
using PresentationLayer.DetailPL;
using PresentationLayer.ClientPL;
using PresentationLayer.ServicePL;
using PresentationLayer.SpecialistPL;
using PresentationLayer.PaymentPL;
using PresentationLayer.CarPL;
using PresentationLayer.ContractPL;
using PresentationLayer.ListOfServicePL;
using PresentationLayer.ListOfDetailPL;
using PresentationLayer.AdminFunc;
using PresentationLayer.AdminReports;

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
            Close();
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
            Close();
            w.Show();
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            AdminServiceWindow w = new AdminServiceWindow();
            Close();
            w.Show();
        }

        private void SpecialistButton_Click(object sender, EventArgs e)
        {
            AdminSpecialistForm f = new AdminSpecialistForm();
            Close();
            f.Show();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            PaymentAdminWindow w = new PaymentAdminWindow();
            Close();
            w.Show();
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            AdminCarWindow w = new AdminCarWindow();
            Close();
            w.Show();
        }

        private void ContractButton_Click(object sender, EventArgs e)
        {
            ContractAdminWindow w = new ContractAdminWindow();
            Close();
            w.Show();
        }

        private void ListofServicesButton_Click(object sender, EventArgs e)
        {
            AdminLoSWindow w = new AdminLoSWindow();
            Close();
            w.Show();
        }

        private void ListofDetailButton_Click(object sender, EventArgs e)
        {
            AdminListOfDetailWindow w = new AdminListOfDetailWindow();
            Close();
            w.Show();
        }

        private void OnlyDetailPrice_Click(object sender, EventArgs e)
        {
            CalcDetailPriceForm f = new CalcDetailPriceForm();
            Close();
            f.Show();
        }

        private void TotalServicesPriceButton_Click(object sender, EventArgs e)
        {
            CalcServicePriceForm f = new CalcServicePriceForm();
            Close();
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CalcTotalPriceForm f = new CalcTotalPriceForm();
            Close();
            f.Show();
        }

        private void Report1Button_Click(object sender, EventArgs e)
        {
            PeriodReportForm f = new PeriodReportForm();
            Close();
            f.Show();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ClientAdminForm f = new ClientAdminForm();
            Close();
            f.Show();
        }
    }
}
