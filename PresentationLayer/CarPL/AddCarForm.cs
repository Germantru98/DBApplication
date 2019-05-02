using System;
using System.Windows.Forms;
using BusinessLogic;
using Entities;

namespace PresentationLayer.CarPL
{
    public partial class AddCarForm : Form
    {
        private ClientLogic clientLogic = new ClientLogic();
        private MarkLogic markLogic = new MarkLogic();
        private CarLogic carLogic = new CarLogic();
        public AddCarForm()
        {
            InitializeComponent();
            ClientsCBox.DataSource = clientLogic.GetAll();
            MarkCBox.DataSource = markLogic.GetAll();
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Client c = (Client)ClientsCBox.SelectedItem;
            Mark m = (Mark)MarkCBox.SelectedItem;
            carLogic.Add(new Car<int>(c.ID,NumberTextBox.Text,m.ID,ModelTextBox.Text,DofMPicker.Value,ColourTextBox.Text));
            Hide();
        }
    }
}
