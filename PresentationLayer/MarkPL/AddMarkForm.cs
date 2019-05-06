using BusinessLogic;
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

namespace PresentationLayer.MarkPL
{
    public partial class AddMarkForm : Form
    {
        private MarkLogic markLogic = new MarkLogic();
        public AddMarkForm()
        {
            InitializeComponent();
        }

        

        private void AddButton_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark(textBox1.Text.ToUpper());            
            markLogic.Add(mark);
            Close();            
        }

        private void AddMarkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
