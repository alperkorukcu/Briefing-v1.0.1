using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Briefing
{
    public partial class Briefing : Form
    {
        public Briefing()
        {
            InitializeComponent();
        }

        //close butonu kapatır
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //panel ile border görevi görme kodu başlangıcı
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);                
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //panel ile border görevi görme kodu sonu

        //pictureBox ile border görevi görme kodu başlangıcı
        int fareX = 0, fareY = 0;
        bool fareDown;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            fareDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (fareDown)
            {
                fareX = MousePosition.X - 435;
                fareY = MousePosition.Y - 16;

                this.SetDesktopLocation(fareX, fareY);
            }
        }        

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            fareDown = false;
        }
        //pictureBox ile border görevi görme kodu sonu

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.closeButton, "Close");
        }

        private void aboutButton_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.aboutButton, "About me");
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.label2, "Remember: this application still under development stage.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 frm3 = new Form4();
            frm3.ShowDialog();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox3, "Sources and Addons");
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox4, "Charts");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form5 frm4 = new Form5();
            frm4.ShowDialog();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox5, "Aviation Rules");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6 frm5 = new Form6();
            frm5.ShowDialog();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox6, "Flight Instruments");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form7 frm6 = new Form7();
            frm6.ShowDialog();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox7, "Airport Weather");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form8 frm7 = new Form8();
            frm7.ShowDialog();
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox8, "Phonetics");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form9 frm8 = new Form9();
            frm8.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form10 frm9 = new Form10();
            frm9.ShowDialog();
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox9, "Calculations");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox2, "Checklists and Communications");            
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.ShowDialog();
        }

        
    }
}
