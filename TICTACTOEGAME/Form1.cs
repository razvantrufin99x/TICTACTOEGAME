using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TICTACTOEGAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int MOD = 0;
        int i = 0;

        public void xc(object sender)
        {
            if (i < 10)
            {
                Button btn;
                btn = (Button)(sender);
                btn.Text = MOD.ToString();
                if (MOD == 0) { MOD = 1; }
                else { MOD = 0; }
                btn.Enabled = false;
            
            Text = i.ToString();
            i++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            xc(sender);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xc(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xc(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xc(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xc(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            xc(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            xc(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            xc(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            xc(sender);
        }
    }
}
