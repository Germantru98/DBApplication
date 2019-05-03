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
using PresentationLayer.ContractPL;

namespace PresentationLayer.ContractPL
{
    public partial class AddContractForm : Form
    {
        private SpecialistLogic specialistLogic = new SpecialistLogic();
        private PaymentLogic paymentLogic = new PaymentLogic();
        private CarLogic carLogic = new CarLogic();
        private ContractLogic contractLogic = new ContractLogic();
        public AddContractForm()
        {
            InitializeComponent();
            SpecialistCBox.DataSource = specialistLogic.GetAllFreeSpecialists();
            PaymentCBox.DataSource = paymentLogic.GetAll();
            CarCBox.DataSource = carLogic.GetAllFreeCars();
            TimeCBox.DataSource = new List<TimeSpan>() { new TimeSpan(1,00,00), new TimeSpan(2, 00, 00), new TimeSpan(3, 00, 00), new TimeSpan(4, 00, 00), new TimeSpan(5, 00, 00)
            ,new TimeSpan(6,00,00),new TimeSpan(7,00,00),new TimeSpan(8,00,00)};
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Car<string> car = (Car<string>)CarCBox.SelectedItem;
            Payment payment = (Payment)PaymentCBox.SelectedItem;
            Specialist specialist = (Specialist)SpecialistCBox.SelectedItem;
            TimeSpan ts = (TimeSpan)TimeCBox.SelectedItem;
            contractLogic.Add(new Contract(specialist.ID, car.ID, DatePicker.Value, ts, DefectTBox.Text, payment.ID));
            Hide();
        }

        private void AddContractForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Текущий объект не добавлен в БД, продолжить?");
        }
    }
}
