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

namespace PresentationLayer.AdminReports
{
    public partial class PeriodReportForm : Form
    {
        private ContractLogic logic = new ContractLogic();
        public PeriodReportForm()
        {
            InitializeComponent();
        }

        private void PeriodReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ContractTable.DataSource = logic.PeriodReport(DateBegin.Value, DateEnd.Value);
        }
    }
}
