using System;
using System.Windows.Forms;
using BusinessLogic;
using PresentationLayer.PaymentPL;

namespace PresentationLayer.PaymentPL
{
    public partial class PaymentAdminWindow : Form
    {
        private PaymentLogic paymentLogic = new PaymentLogic();
        public PaymentAdminWindow()
        {
            InitializeComponent();
            PaymentTable.DataSource = paymentLogic.GetAll();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int id = (int)PaymentTable.CurrentRow.Cells[0].Value;
            paymentLogic.Remove(id);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PaymentTable.DataSource = paymentLogic.GetAll();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPaymentForm f = new AddPaymentForm();
            f.Show();
        }

        private void PaymentAdminWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }
    }
}
