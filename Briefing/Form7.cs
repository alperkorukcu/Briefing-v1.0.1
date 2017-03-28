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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox1, "Chapter 1: Introduction to Advanced Avionics");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process proc1 = new Process();
            proc1.StartInfo.UseShellExecute = true;
            proc1.EnableRaisingEvents = false;
            proc1.StartInfo.FileName = "https://www.faa.gov/regulations_policies/handbooks_manuals/aviation/advanced_avionics_handbook/media/aah_ch01.pdf";
            proc1.Start();
            proc1.Close();
            proc1.Dispose();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox2, "Chapter 2: Electronic Flight Instruments");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process proc2 = new Process();
            proc2.StartInfo.UseShellExecute = true;
            proc2.EnableRaisingEvents = false;
            proc2.StartInfo.FileName = "https://www.faa.gov/regulations_policies/handbooks_manuals/aviation/advanced_avionics_handbook/media/aah_ch02.pdf";
            proc2.Start();
            proc2.Close();
            proc2.Dispose();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox3, "Chapter 3: Navigation");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process proc3 = new Process();
            proc3.StartInfo.UseShellExecute = true;
            proc3.EnableRaisingEvents = false;
            proc3.StartInfo.FileName = "https://www.faa.gov/regulations_policies/handbooks_manuals/aviation/advanced_avionics_handbook/media/aah_ch03.pdf";
            proc3.Start();
            proc3.Close();
            proc3.Dispose();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox4, "Chapter 4: Automated Flight Control");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process proc4 = new Process();
            proc4.StartInfo.UseShellExecute = true;
            proc4.EnableRaisingEvents = false;
            proc4.StartInfo.FileName = "https://www.faa.gov/regulations_policies/handbooks_manuals/aviation/advanced_avionics_handbook/media/aah_ch04.pdf";
            proc4.Start();
            proc4.Close();
            proc4.Dispose();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox5, "Chapter 5: Information Systems");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process proc5 = new Process();
            proc5.StartInfo.UseShellExecute = true;
            proc5.EnableRaisingEvents = false;
            proc5.StartInfo.FileName = "https://www.faa.gov/regulations_policies/handbooks_manuals/aviation/advanced_avionics_handbook/media/aah_ch05.pdf";
            proc5.Start();
            proc5.Close();
            proc5.Dispose();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox6, "Essential Skills Checklist");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process proc6 = new Process();
            proc6.StartInfo.UseShellExecute = true;
            proc6.EnableRaisingEvents = false;
            proc6.StartInfo.FileName = "https://www.faa.gov/regulations_policies/handbooks_manuals/aviation/advanced_avionics_handbook/media/aah_back.pdf";
            proc6.Start();
            proc6.Close();
            proc6.Dispose();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox7, "Advanced Avionics Handbook Full Version");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process proc7 = new Process();
            proc7.StartInfo.UseShellExecute = true;
            proc7.EnableRaisingEvents = false;
            proc7.StartInfo.FileName = "https://www.faa.gov/regulations_policies/handbooks_manuals/aviation/advanced_avionics_handbook/media/FAA-H-8083-6.pdf";
            proc7.Start();
            proc7.Close();
            proc7.Dispose();
        }
    }
}
