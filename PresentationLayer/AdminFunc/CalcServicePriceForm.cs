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

namespace PresentationLayer.AdminFunc
{
    public partial class CalcServicePriceForm : Form
    {
        private ListOfServiceLogic logic = new ListOfServiceLogic();
        private ContractLogic contractLogic = new ContractLogic();
        public CalcServicePriceForm()
        {
            InitializeComponent();
            comboBox1.DataSource = contractLogic.GetAll();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Contract c = (Contract)comboBox1.SelectedItem;
            decimal result = logic.TotalPrice(c.ID);
            if (result != 0)
            {
                textBox1.Text = result.ToString();
            }
            else
            {
                textBox1.Text = "Нет услуг по данному контракту";
            }
        }

        private void CalcServicePriceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }
    }
}
