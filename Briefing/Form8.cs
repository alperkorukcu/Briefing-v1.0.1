using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Briefing
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
                ToolTip4.SetToolTip(this.pictureBox2, "You can search from here ICAO codes for airports.");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
                ToolTip2.SetToolTip(this.pictureBox1, "See airport weather from Aviation Digital Data Service (ADDS).");
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip5 = new System.Windows.Forms.ToolTip();
            ToolTip5.SetToolTip(this.textBox1, "Type airport's ICAO code here.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "ICAO CODE" && textBox1.Text.Length == 4)
            {
                Process proc1 = new Process();
                proc1.StartInfo.UseShellExecute = true;
                proc1.EnableRaisingEvents = false;
                proc1.StartInfo.FileName = "http://www.aviationweather.gov/adds/tafs/?station_ids=" + textBox1.Text.ToUpper() + "&std_trans=translated&submit_both=Get+TAFs+and+METARs";
                proc1.Start();
                proc1.Close();
                proc1.Dispose();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process proc2 = new Process();
            proc2.StartInfo.UseShellExecute = true;
            proc2.EnableRaisingEvents = false;
            proc2.StartInfo.FileName = "http://www.airlinecodes.co.uk/aptcodesearch.asp";
            proc2.Start();
            proc2.Close();
            proc2.Dispose();
        }
    }
}
