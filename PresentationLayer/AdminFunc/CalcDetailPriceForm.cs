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

namespace PresentationLayer.AdminFunc
{
    public partial class CalcDetailPriceForm : Form
    {
        private ContractLogic clogic = new ContractLogic();
        private ListOfDetailLogic detailLogic = new ListOfDetailLogic();
        public CalcDetailPriceForm()
        {
            InitializeComponent();
            comboBox1.DataSource = clogic.GetAll();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Contract c = (Contract)comboBox1.SelectedItem;
            decimal result = detailLogic.TotalPrice(c.ID);
            if (result != 0)
            {
                textBox1.Text = result.ToString();
            }
            else
            {
                textBox1.Text = "Нет деталей по данному контракту";
            }
        }

        private void CalcDetailPriceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }
    }
}
