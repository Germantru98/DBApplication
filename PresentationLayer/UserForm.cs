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

namespace PresentationLayer
{
    public partial class UserForm : Form
    {
        private SpecialistLogic specialistLogic = new SpecialistLogic();
        private DetailLogic detailLogic = new DetailLogic();
        private ServiceLogic serviceLogic = new ServiceLogic();
        private MarkLogic markLogic = new MarkLogic();
        public UserForm()
        {
            InitializeComponent();
            SpecialistsTab.DataSource = specialistLogic.GetAll();
            DetailTab.DataSource = detailLogic.GetAll();
            ServiceTab.DataSource = serviceLogic.GetAll();
            MarkTable.DataSource = markLogic.GetAll();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminUserForm f = new AdminUserForm();
            f.Show();
        }
    }
}
