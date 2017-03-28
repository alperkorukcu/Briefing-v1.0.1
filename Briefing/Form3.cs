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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox1, "My Facebook");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox3, "My GMail");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox2, "My Steam");
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox4, "My LinkedIn");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process proc1 = new Process();
            proc1.StartInfo.UseShellExecute = true;
            proc1.EnableRaisingEvents = false;
            proc1.StartInfo.FileName = "https://www.facebook.com/alperkorukcu";
            proc1.Start();
            proc1.Close();
            proc1.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process proc2 = new Process();
            proc2.StartInfo.UseShellExecute = true;
            proc2.EnableRaisingEvents = false;
            proc2.StartInfo.FileName = "mailto:alperkorukcu@gmail.com";
            proc2.Start();
            proc2.Close();
            proc2.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process proc3 = new Process();
            proc3.StartInfo.UseShellExecute = true;
            proc3.EnableRaisingEvents = false;
            proc3.StartInfo.FileName = "http://steamcommunity.com/id/wizardfrog/";
            proc3.Start();
            proc3.Close();
            proc3.Dispose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process proc4 = new Process();
            proc4.StartInfo.UseShellExecute = true;
            proc4.EnableRaisingEvents = false;
            proc4.StartInfo.FileName = "https://www.linkedin.com/in/yunus-alper-k%C3%B6r%C3%BCkc%C3%BC-72853ba8";
            proc4.Start();
            proc4.Close();
            proc4.Dispose();
        }
    }
}
