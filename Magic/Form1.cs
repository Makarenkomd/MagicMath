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
        int k;
        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel1.Width = 40 * 20 + 100;
            flowLayoutPanel1.Height = 40 * 10 + 100;
            Start();
        }

        Label Symbol(int a)
        {
            Label l = new Label();
            l.Width = 40;
            l.Height = 40;
            l.BackColor = Color.Black;
            l.Margin = new Padding(3,3,0,3);
            l.Text = getSymbol(a);
            l.Font = new Font("Wingdings", 22);
            l.ForeColor = Color.White;
            l.TextAlign = ContentAlignment.MiddleCenter;
            flowLayoutPanel1.Controls.Add(l);
            return l;
        }

        string getSymbol(int a)
        {
            return Convert.ToChar(a + 35).ToString();
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

        void Start()
        {
            Random rnd = new Random();
            k = rnd.Next(26);
            flowLayoutPanel1.Controls.Clear();
            label1.Text = "";
            for (int i = 0; i < 100; i++)
            {
                Digit(i);
                if (i % 9 == 0)
                    Symbol(k);
                else
                    Symbol(rnd.Next(26));
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = getSymbol(k);
        }
    }
}
