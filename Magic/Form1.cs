using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Label l = new Label();
            l.Width = 40;
            l.Height = 40;
            l.BackColor = Color.Black;
            l.Margin = new Padding(3);
            l.Text = "5";
            l.Font = new Font("Wingdings", 22);
            l.ForeColor = Color.White;
            l.TextAlign = ContentAlignment.MiddleCenter;
            flowLayoutPanel1.Controls.Add(l);
        }
    }
}
