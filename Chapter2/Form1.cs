using System;
using System.Windows.Forms;

namespace Chapter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            lblMessage.Text = $"{lblMessage.BorderStyle}";
        }
    }
}