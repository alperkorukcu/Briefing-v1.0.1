﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Diagnostics;

namespace Briefing
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.textBox1, "Type airport's ICAO code here.");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                ToolTip1.SetToolTip(this.pictureBox1, "See airport charts from Fly Sea.");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                ToolTip1.SetToolTip(this.pictureBox2, "See airport charts from Vau (Virtual Airlines of Ukraine) Aero.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "ICAO CODE" && textBox1.Text.Length == 4)
            {
                Process proc1 = new Process();
                proc1.StartInfo.UseShellExecute = true;
                proc1.EnableRaisingEvents = false;
                proc1.StartInfo.FileName = "http://www.fly-sea.com/charts/" + textBox1.Text.ToUpper() + ".pdf";
                proc1.Start();
                proc1.Close();
                proc1.Dispose();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "ICAO CODE" && textBox1.Text.Length == 4)
            {
                Process proc2 = new Process();
                proc2.StartInfo.UseShellExecute = true;
                proc2.EnableRaisingEvents = false;
                proc2.StartInfo.FileName = "http://vau.aero/navdb/chart/" + textBox1.Text.ToUpper() + ".pdf";
                proc2.Start();
                proc2.Close();
                proc2.Dispose();
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                ToolTip1.SetToolTip(this.pictureBox3, "You can search from here ICAO codes for airports.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process proc3 = new Process();
            proc3.StartInfo.UseShellExecute = true;
            proc3.EnableRaisingEvents = false;
            proc3.StartInfo.FileName = "http://www.airlinecodes.co.uk/aptcodesearch.asp";
            proc3.Start();
            proc3.Close();
            proc3.Dispose();
        }
    }    
}
