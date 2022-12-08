﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelBrot
{
    public partial class Form2 : Form
    {

        public Form thisForm;
        public Form2()
        {
            InitializeComponent();
            thisForm = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thisForm.Close();
            Form form1 = new Form1();
            
            TextBox midXTb = (TextBox)form1.Controls["midXTb"];
            midXTb.Text = "-0,0040685963";

            TextBox midYTb = (TextBox)form1.Controls["midYTb"];
            midYTb.Text = "-0,8089094";

            TextBox scaleFactorTb = (TextBox)form1.Controls["scaleFactorTb"];
            scaleFactorTb.Text = "3,6893514E-08";

            TextBox maxIterationsTb = (TextBox)form1.Controls["maxIterationsTb"];
            maxIterationsTb.Text = "1000";

            form1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            thisForm.Close();
            Form form1 = new Form1();

            TextBox midXTb = (TextBox)form1.Controls["midXTb"];
            midXTb.Text = "0,006875";

            TextBox midYTb = (TextBox)form1.Controls["midYTb"];
            midYTb.Text = "0,80638671875";

            TextBox scaleFactorTb = (TextBox)form1.Controls["scaleFactorTb"];
            scaleFactorTb.Text = "9,765625E-06";

            TextBox maxIterationsTb = (TextBox)form1.Controls["maxIterationsTb"];
            maxIterationsTb.Text = "1000";

            form1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            thisForm.Close();
            Form form1 = new Form1();

            TextBox midXTb = (TextBox)form1.Controls["midXTb"];
            midXTb.Text = "-0,0030880242";

            TextBox midYTb = (TextBox)form1.Controls["midYTb"];
            midYTb.Text = "-0,8170546";

            TextBox scaleFactorTb = (TextBox)form1.Controls["scaleFactorTb"];
            scaleFactorTb.Text = "2,1990243E-07";

            TextBox maxIterationsTb = (TextBox)form1.Controls["maxIterationsTb"];
            maxIterationsTb.Text = "1000";

            form1.Show();

        }
    }
}
