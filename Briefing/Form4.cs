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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox1, "Avsim" + "\n" + "AVSIM is a flight simulation review and resource website that focuses heavily on Microsoft Flight Simulator.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process proc1 = new Process();
            proc1.StartInfo.UseShellExecute = true;
            proc1.EnableRaisingEvents = false;
            proc1.StartInfo.FileName = "http://www.avsim.com/index.php/";
            proc1.Start();
            proc1.Close();
            proc1.Dispose();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox2, "Flightradar24" + "\n" + "Flightradar24 is a Swedish internet-based service that shows real-time aircraft flight information on a map.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process proc2 = new Process();
            proc2.StartInfo.UseShellExecute = true;
            proc2.EnableRaisingEvents = false;
            proc2.StartInfo.FileName = "http://www.flightradar24.com/";
            proc2.Start();
            proc2.Close();
            proc2.Dispose();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox3, "FlightSim" + "\n" + "FlightSim.Com is a flight simulation review and resource website that focuses heavily on Microsoft Flight Simulator.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process proc3 = new Process();
            proc3.StartInfo.UseShellExecute = true;
            proc3.EnableRaisingEvents = false;
            proc3.StartInfo.FileName = "http://www.flightsim.com/vbfs/content.php";
            proc3.Start();
            proc3.Close();
            proc3.Dispose();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox4, "Fly Away" + "\n" + "The Fly Away Simulation downloads directory is one of the biggest and most well organized file libraries there is.");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process proc4 = new Process();
            proc4.StartInfo.UseShellExecute = true;
            proc4.EnableRaisingEvents = false;
            proc4.StartInfo.FileName = "https://www.flyawaysimulation.com/";
            proc4.Start();
            proc4.Close();
            proc4.Dispose();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox5, "Ivao" + "\n" + "IVAO or International Virtual Aviation Organisation VZW is a non-profit association which operates a free-of-charge online flight-simulation network.");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process proc5 = new Process();
            proc5.StartInfo.UseShellExecute = true;
            proc5.EnableRaisingEvents = false;
            proc5.StartInfo.FileName = "https://www.ivao.aero/";
            proc5.Start();
            proc5.Close();
            proc5.Dispose();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox6, "Rikoooo" + "\n" + "Rikoooo.com is a French website devoted to flight simulation on computer, mostly dedicated to Microsoft “Flight Simulator”, with some elements about “Laminar Research” and “X-Plane”.");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process proc6 = new Process();
            proc6.StartInfo.UseShellExecute = true;
            proc6.EnableRaisingEvents = false;
            proc6.StartInfo.FileName = "http://www.rikoooo.com/en/";
            proc6.Start();
            proc6.Close();
            proc6.Dispose();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox7, "RouteFinder" + "\n" + "This route generator service is provided free of charge to the Flight Simulation Community.");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process proc7 = new Process();
            proc7.StartInfo.UseShellExecute = true;
            proc7.EnableRaisingEvents = false;
            proc7.StartInfo.FileName = "http://rfinder.asalink.net/free/";
            proc7.Start();
            proc7.Close();
            proc7.Dispose();
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox8, "SimBrief" + "\n" + "SimBrief.com was created with the intent of sharing a series of flight planning tools with the general Flight Simulation community.");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process proc8 = new Process();
            proc8.StartInfo.UseShellExecute = true;
            proc8.EnableRaisingEvents = false;
            proc8.StartInfo.FileName = "http://www.simbrief.com/home/";
            proc8.Start();
            proc8.Close();
            proc8.Dispose();
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox9, "Simviation" + "\n" + "Simviation provides free aircraft, more planes, addons, more scenery and airports. High quality freeware aircraft addons. Expansion packs for flight simulator.");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process proc9 = new Process();
            proc9.StartInfo.UseShellExecute = true;
            proc9.EnableRaisingEvents = false;
            proc9.StartInfo.FileName = "http://simviation.com/";
            proc9.Start();
            proc9.Close();
            proc9.Dispose();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Process proc12 = new Process();
            proc12.StartInfo.UseShellExecute = true;
            proc12.EnableRaisingEvents = false;
            proc12.StartInfo.FileName = "http://www.aero.sors.fr/navaids3.html";
            proc12.Start();
            proc12.Close();
            proc12.Dispose();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Process proc11 = new Process();
            proc11.StartInfo.UseShellExecute = true;
            proc11.EnableRaisingEvents = false;
            proc11.StartInfo.FileName = "http://www.flightsim2004-fanatics.com/FlightSim/FSXWingSpanValues.htm";
            proc11.Start();
            proc11.Close();
            proc11.Dispose();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Process proc10 = new Process();
            proc10.StartInfo.UseShellExecute = true;
            proc10.EnableRaisingEvents = false;
            proc10.StartInfo.FileName = "http://www.freechecklists.net/";
            proc10.Start();
            proc10.Close();
            proc10.Dispose();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Process proc13 = new Process();
            proc13.StartInfo.UseShellExecute = true;
            proc13.EnableRaisingEvents = false;
            proc13.StartInfo.FileName = "https://www.vatsim.net/";
            proc13.Start();
            proc13.Close();
            proc13.Dispose();
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox10, "Free Checklists" + "\n" + "The web's largest collection of checklists.");
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox11, "Flightsim Fanatics" + "\n" + "Wing Span in Meters, 1/2 Wing Span Value, FSX Parking Spot Size Used, Parking Spot Type.");
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox12, "Aero.Sors Navaids" + "\n" + "The FSX/P3D World Navaids package will update navigational aids (VORs, NDBs) in selectable world areas (worldwide coverage).");
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox13, "Vatsim" + "\n" + "VATSIM (short for the Virtual Air Traffic Simulation Network) is a completely free online platform which allows virtual pilots, wherever they are in the world, to connect their flight simulators into one shared virtual world.");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Process proc14 = new Process();
            proc14.StartInfo.UseShellExecute = true;
            proc14.EnableRaisingEvents = false;
            proc14.StartInfo.FileName = "http://www.airlinecodes.co.uk/home.asp";
            proc14.Start();
            proc14.Close();
            proc14.Dispose();
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox14, "The Airline Codes Website" + "\n" + "This web site has been setup to help you cut through the jungle of all those codes and abbreviations used in and around the Airline Industry.");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Process proc16 = new Process();
            proc16.StartInfo.UseShellExecute = true;
            proc16.EnableRaisingEvents = false;
            proc16.StartInfo.FileName = "http://vau.aero/route/";
            proc16.Start();
            proc16.Close();
            proc16.Dispose();
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox16, "Virtual Airlines of Ukraine Website" + "\n" + "This web site provides you a pathfinder system for FSX/P3D.");
        }

        private void pictureBox15_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox15, "PMDG" + "\n" + "PMDG has been producing tools and software to support the serious flight simulation enthusiast for many years.");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Process proc15 = new Process();
            proc15.StartInfo.UseShellExecute = true;
            proc15.EnableRaisingEvents = false;
            proc15.StartInfo.FileName = "https://www.precisionmanuals.com/";
            proc15.Start();
            proc15.Close();
            proc15.Dispose();
        }

        private void pictureBox17_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox17, "Active Sky" + "\n" + "Active Sky 2016 (AS16) represents the culmination of 16 years of weather simulation engine development!  New In-Cloud Motion Effects, Weather Scenarios System, Airborne Weather Radar, P3D v3 Visibility Smoothing and Volumetric Fog Integration, Navigraph Data Integration, Re-designed Map-based Custom Weather Editing System, Universal Web Companion App, an Improved Mapping System and a High-Latitude Cloud Squeeze Fix are just a few of the new features to debut in this brand new version of Active Sky.");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Process proc17 = new Process();
            proc17.StartInfo.UseShellExecute = true;
            proc17.EnableRaisingEvents = false;
            proc17.StartInfo.FileName = "http://www.hifisimtech.com/";
            proc17.Start();
            proc17.Close();
            proc17.Dispose();
        }

        private void pictureBox18_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox18, "REX Simulations" + "\n" + "High-Quality Realistic Weather, Texture and Effects Software for Flight Simulation.");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Process proc18 = new Process();
            proc18.StartInfo.UseShellExecute = true;
            proc18.EnableRaisingEvents = false;
            proc18.StartInfo.FileName = "http://www.rexsimulations.com/";
            proc18.Start();
            proc18.Close();
            proc18.Dispose();
        }

        private void pictureBox19_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox19, "Orbx Ftx Global" + "\n" + "Simply put, it transforms the washed out bland textures of the default palette into the vibrant, rich and appealing Orbx FTX landscape - all with a simple installer.");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Process proc19 = new Process();
            proc19.StartInfo.UseShellExecute = true;
            proc19.EnableRaisingEvents = false;
            proc19.StartInfo.FileName = "https://www.fullterrain.com/";
            proc19.Start();
            proc19.Close();
            proc19.Dispose();
        }

        private void pictureBox20_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox20, "EZdok" + "\n" + "Ezdok Camera Addon (EZCA) is a tool for Microsoft Flight Simulator X. ");
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Process proc20 = new Process();
            proc20.StartInfo.UseShellExecute = true;
            proc20.EnableRaisingEvents = false;
            proc20.StartInfo.FileName = "http://www.ezdok-software.com/index.html";
            proc20.Start();
            proc20.Close();
            proc20.Dispose();
        }

        private void pictureBox21_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox21, "A2A Simulations / Accu Feel" + "\n" + "Accu-Feel enables you to customize numerous aspects of your aircraft’s behaviour, from the level of turbulence and drag rumble experienced in different flying conditions to the amount of tyre screech on touchdown.");
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Process proc21 = new Process();
            proc21.StartInfo.UseShellExecute = true;
            proc21.EnableRaisingEvents = false;
            proc21.StartInfo.FileName = "https://a2asimulations.com/";
            proc21.Start();
            proc21.Close();
            proc21.Dispose();
        }

        private void pictureBox22_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox22, "Fs2 Crew / Raas Pro" + "\n" + "The FS2Crew product line was established by an international team of programmers, graphic artists and airline professionals who came together to create realistic airline crew simulations for Flight Simulator.");
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Process proc22 = new Process();
            proc22.StartInfo.UseShellExecute = true;
            proc22.EnableRaisingEvents = false;
            proc22.StartInfo.FileName = "http://www.fs2crew.com/cart/";
            proc22.Start();
            proc22.Close();
            proc22.Dispose();
        }

        private void pictureBox23_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox23, "Wilco Publishing / Airbus" + "\n" + "Wilco Publishing has gathered together a team of very talented and dedicated developers to produce high quality and exciting flight sim products.");
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Process proc23 = new Process();
            proc23.StartInfo.UseShellExecute = true;
            proc23.EnableRaisingEvents = false;
            proc23.StartInfo.FileName = "http://www.wilcopub.com/";
            proc23.Start();
            proc23.Close();
            proc23.Dispose();
        }
    }
}
