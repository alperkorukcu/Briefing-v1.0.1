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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox1, "American Aviation Rules");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process proc1 = new Process();
            proc1.StartInfo.UseShellExecute = true;
            proc1.EnableRaisingEvents = false;
            proc1.StartInfo.FileName = "http://www.faa.gov/";
            proc1.Start();
            proc1.Close();
            proc1.Dispose();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox4, "European Aviation Rules");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process proc2 = new Process();
            proc2.StartInfo.UseShellExecute = true;
            proc2.EnableRaisingEvents = false;
            proc2.StartInfo.FileName = "https://www.easa.europa.eu/";
            proc2.Start();
            proc2.Close();
            proc2.Dispose();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox5, "African Aviation Rules");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process proc3 = new Process();
            proc3.StartInfo.UseShellExecute = true;
            proc3.EnableRaisingEvents = false;
            proc3.StartInfo.FileName = "http://www.caa.co.za/Pages/default.aspx";
            proc3.Start();
            proc3.Close();
            proc3.Dispose();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox6, "Asian Aviation Rules");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process proc4 = new Process();
            proc4.StartInfo.UseShellExecute = true;
            proc4.EnableRaisingEvents = false;
            proc4.StartInfo.FileName = "http://www.caa.lk/";
            proc4.Start();
            proc4.Close();
            proc4.Dispose();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox3, "Australian Aviation Rules");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process proc5 = new Process();
            proc5.StartInfo.UseShellExecute = true;
            proc5.EnableRaisingEvents = false;
            proc5.StartInfo.FileName = "https://www.casa.gov.au/";
            proc5.Start();
            proc5.Close();
            proc5.Dispose();
        }
    }
}
