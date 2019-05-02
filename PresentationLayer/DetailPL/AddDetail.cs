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

namespace PresentationLayer.DetailPL
{
    public partial class AddDetail : Form
    {
        private DetailLogic detailLogic = new DetailLogic();
        public AddDetail()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(textBox1.Text, decimal.Parse( textBox2.Text));
            detailLogic.Add(detail);
            Hide();
        }

        private void AddDetail_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
