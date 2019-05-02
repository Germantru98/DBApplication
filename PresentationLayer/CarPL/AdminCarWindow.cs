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

namespace PresentationLayer.CarPL
{
    public partial class AdminCarWindow : Form
    {
        private CarLogic carLogic = new CarLogic();
        public AdminCarWindow()
        {
            InitializeComponent();
            CarTable.DataSource = carLogic.GetAll();
        }
    }
}
