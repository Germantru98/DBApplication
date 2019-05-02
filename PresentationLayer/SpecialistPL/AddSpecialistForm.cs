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

namespace PresentationLayer.SpecialistPL
{
    public partial class AddSpecialistForm : Form
    {
        private SpecialistLogic specialistLogic = new SpecialistLogic();
        public AddSpecialistForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            specialistLogic.Add(new Specialist(NameTextBox.Text, SnameTextBox.Text, QualificationTextBox.Text));
            Hide();
        }
    }
}
