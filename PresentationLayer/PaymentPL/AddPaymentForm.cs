using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BusinessLogic;
using System.Windows.Forms;

namespace PresentationLayer.PaymentPL
{
    public partial class AddPaymentForm : Form
    {
        private PaymentLogic paymentLogic = new PaymentLogic();
        public AddPaymentForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            paymentLogic.Add(new Payment(PaymentName.Text, PaymentType.Text));
            Hide();
        }
    }
}
