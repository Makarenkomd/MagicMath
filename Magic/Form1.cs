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
            flowLayoutPanel1.Width = 40 * 20 + 100;
            flowLayoutPanel1.Height = 40 * 10 + 100;

        }

        Label Symbol(int a)
        {
            Label l = new Label();
            l.Width = 40;
            l.Height = 40;
            l.BackColor = Color.Black;
            l.Margin = new Padding(3,3,0,3);
            l.Text = Convert.ToChar(a+35).ToString();
            l.Font = new Font("Wingdings", 22);
            l.ForeColor = Color.White;
            l.TextAlign = ContentAlignment.MiddleCenter;
            flowLayoutPanel1.Controls.Add(l);
            return l;
        }
        Label Digit(int a)
        {
            Label l = new Label();
            l.Width = 40;
            l.Height = 40;
            l.BackColor = Color.White;
            l.Margin = new Padding(3,3,3,0);
            l.Text = a.ToString();
            l.Font = new Font("Arial", 14);
            l.ForeColor = Color.Black;
            l.TextAlign = ContentAlignment.MiddleCenter;
            flowLayoutPanel1.Controls.Add(l);
            return l;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 100; i++)
            {
                Digit(i);
                Symbol(rnd.Next(26));
            }
        }
    }
}
