﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class MetPuls : Form
    {
        public MetPuls()
        {
            InitializeComponent();
        }
        // + + CULORI
        private void MetPuls_Load(object sender, EventArgs e)
        {
            BackColor = System.Drawing.ColorTranslator.FromHtml("#F7F5E6");
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#424b70");
            label1.BackColor = System.Drawing.ColorTranslator.FromHtml("#424b70");
            label2.BackColor = System.Drawing.ColorTranslator.FromHtml("#424b70");
            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F7F5E6");
            label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F7F5E6");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#424b70");
            label3.BackColor = System.Drawing.ColorTranslator.FromHtml("#F7F5E6");
            label3.Visible = false;
            label4.BackColor = System.Drawing.ColorTranslator.FromHtml("#424b70");
            label4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F7F5E6");
            label5.BackColor = System.Drawing.ColorTranslator.FromHtml("#424b70");
            label5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F7F5E6");
            label6.BackColor = System.Drawing.ColorTranslator.FromHtml("#424b70");
            label6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F7F5E6");
            label7.BackColor = System.Drawing.ColorTranslator.FromHtml("#424b70");
            label7.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F7F5E6");
            label8.BackColor = System.Drawing.ColorTranslator.FromHtml("#424b70");
            label8.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F7F5E6");
        }
        
        public void aflareTens()
        {
            int x = Convert.ToInt16(label6.Text);
            if(x>= 40 && x <= 60)
            {
                label3.Text = "Sub Tensiune";
                pictureBox1.Image = Properties.Resources.;
            }

        }
        
    }
}
