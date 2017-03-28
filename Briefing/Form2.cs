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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            checkedListBox1.HorizontalScrollbar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.ScrollAlwaysVisible = false;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.HorizontalExtent = 780;
            checkedListBox1.Items.Add("<YourCallsign>: Good morning <TowerName> Tower, <YourCallsign> information ECHO, parked at gate <GateCode>, request IFR clearance to <Destination>.");
            checkedListBox1.Items.Add("ATC: <YourCallsign> roger so s/u appreoved, you cleared to <Destination> via <TaxiWays> departure route from <Runway> Squawk <SquawkCode>.");
            checkedListBox1.Items.Add("<YourCallsign>: departure <Runway> via <TaxiWays> Squawk <SquawkCode>, <YourCallsign> s/u and push approved.");
            checkedListBox1.Items.Add("ATC: <YourCallsign> readback is correct p/b approved facing <Direction>.");
            checkedListBox1.Items.Add("<YourCallsign>: p/b approved facing now, <YourCallsign>.");
            checkedListBox1.Items.Add("Parking Brake");
            checkedListBox1.Items.Add("Throttle");
            checkedListBox1.Items.Add("Fuel Systems");
            checkedListBox1.Items.Add("Battery Master Switch");
            checkedListBox1.Items.Add("Flaps");
            checkedListBox1.Items.Add("Spoilers");
            checkedListBox1.Items.Add("Flight Constrols");
            checkedListBox1.Items.Add("Pitot Heat");
            checkedListBox1.Items.Add("Avionics");
            checkedListBox1.Items.Add("Weather Conditions");
            checkedListBox1.Items.Add("De-Icing");
            checkedListBox1.Items.Add("Transponder");
            checkedListBox1.Items.Add("Lighting");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.ScrollAlwaysVisible = false;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.HorizontalExtent = 450;
            checkedListBox1.Items.Add("<YourCallsign>: <YourCallsign> ready for taxi to <Ruwnway>.");
            checkedListBox1.Items.Add("ATC: <YourCallsign> taxi to holding point <Runway> via <TaxiWays>.");
            checkedListBox1.Items.Add("<YourCallsign>: <YourCallsign> taxing for holding point for <Runway> via <Taxiways>.");
            checkedListBox1.Items.Add("Engine Area");
            checkedListBox1.Items.Add("Thrust Levers");
            checkedListBox1.Items.Add("Engine Start Switches");
            checkedListBox1.Items.Add("N1 = N2");
            checkedListBox1.Items.Add("Oil Pressure");
            checkedListBox1.Items.Add("Auto-Pilot");
            checkedListBox1.Items.Add("Auto-Brake");
            checkedListBox1.Items.Add("Trim Settings");
            checkedListBox1.Items.Add("Brakes");
            checkedListBox1.Items.Add("Assigned Runway");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.ScrollAlwaysVisible = false;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.HorizontalExtent = 650;
            checkedListBox1.Items.Add("<YourCallsign>: <YourCallsign> at holding point for <Runway>, ready for departure.");
            checkedListBox1.Items.Add("ATC: <YourCallsign> wind 130 degrees 10 knots <Runway> cleared for take off, when airborne contact unicom <CommFreq>.");
            checkedListBox1.Items.Add("<YourCallsign>: wind copied cleared for take off from <Runway> after departure switching unicom <CommFreq>.");
            checkedListBox1.Items.Add("<YourCallsign>: <YourCallsign> airborne switching <CommFreq> have a good day, bb.");
            checkedListBox1.Items.Add("ATC:Have a good flight, bb.");
            checkedListBox1.Items.Add("Flaps");
            checkedListBox1.Items.Add("Flight Director");
            checkedListBox1.Items.Add("Flight Controls");
            checkedListBox1.Items.Add("Flight Instruments");
            checkedListBox1.Items.Add("Throttle");
            checkedListBox1.Items.Add("Lighting");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.ScrollAlwaysVisible = false;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Items.Add("Positive Rate of Climb");
            checkedListBox1.Items.Add("Gear Up");
            checkedListBox1.Items.Add("Flaps");
            checkedListBox1.Items.Add("Auto-Pilot");
            checkedListBox1.Items.Add("Landing Lights");
            checkedListBox1.Items.Add("Altimeters");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.ScrollAlwaysVisible = false;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Items.Add("Altimeter");
            checkedListBox1.Items.Add("Thrust Levers");
            checkedListBox1.Items.Add("Trim");
            checkedListBox1.Items.Add("Lighting");
            checkedListBox1.Items.Add("Auto-Pilot");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.ScrollAlwaysVisible = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.HorizontalExtent = 650;
            checkedListBox1.Items.Add("[Descent]");
            checkedListBox1.Items.Add("<YourCallsign>: <YourCallsign> inbound <VOR>, descending to <FlightLevel> with you.");
            checkedListBox1.Items.Add("Apprach: <YourCallsign> radar identified, check information HOTEL expect ILS approach <Runway>, descent <Altitude>.");
            checkedListBox1.Items.Add("<YourCallsign>: Information HOTEL on board, down to <Altitude> expecting ILS <Runway>, <YourCallsign>.");
            checkedListBox1.Items.Add("Apprach: <YourCallsign> turn <Direction> heading <Heading>.");
            checkedListBox1.Items.Add("<YourCallsign>: <Direction> to <Heading>, <YourCallsign>.");
            checkedListBox1.Items.Add("Apprach: <YourCallsign> descent altitude <Altitude>, QNH 1006.");
            checkedListBox1.Items.Add("<YourCallsign>: Down to <Altitude> and QNH 1006, <YourCallsign>.");
            checkedListBox1.Items.Add("Apprach: <YourCallsign> cleared ILS approach runway <Runway>.");
            checkedListBox1.Items.Add("<YourCallsign>: Cleared ILS approach runway <Runway>, <YourCallsign>.");
            checkedListBox1.Items.Add("<YourCallsign>: <YourCallsign> loc established with runway <Runway>, ILS full establish will be report.");
            checkedListBox1.Items.Add("Apprach: <YourCallsign>, Thank you.");
            checkedListBox1.Items.Add("<YourCallsign>: <YourCallsign>, ILS full established with runway <Runway>.");
            checkedListBox1.Items.Add("Apprach: <YourCallsign> roger contact tower on <CommFreq>, have a nice evening sir, see you new time goodbye.");
            checkedListBox1.Items.Add("<YourCallsign>: Switching <CommFreq> thanks for the service bb, <YourCallsign>.");
            checkedListBox1.Items.Add("Review Approach Check");
            checkedListBox1.Items.Add("Airspeeds");
            checkedListBox1.Items.Add("Altimeter");
            checkedListBox1.Items.Add("Radios");
            checkedListBox1.Items.Add("De-Ice");
            checkedListBox1.Items.Add("Avionics");
            checkedListBox1.Items.Add("Landing Lights");
            checkedListBox1.Items.Add("Auto-Pilot");
            checkedListBox1.Items.Add("[Final Approach]");
            checkedListBox1.Items.Add("Airspeed");
            checkedListBox1.Items.Add("Thrust Levers");
            checkedListBox1.Items.Add("Flaps");
            checkedListBox1.Items.Add("Auto-Pilot");
            checkedListBox1.Items.Add("Landing Gear");
            checkedListBox1.Items.Add("Speedbrake Armed");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.ScrollAlwaysVisible = false;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.HorizontalExtent = 650;
            checkedListBox1.Items.Add("<YourCallsign>: <YourCallsign>, ILS full established runway <Runway> with you.");
            checkedListBox1.Items.Add("Tower: <YourCallsign>, hello wind is 220 degrees / 28 knots runway <Runway> cleared to land.");
            checkedListBox1.Items.Add("<YourCallsign>: Wind copied cleared to land runway <Runway>, <YourCallsign>.");
            checkedListBox1.Items.Add("<YourCallsign>: <YourCallsign>, vacating runway <Runway>.");
            checkedListBox1.Items.Add("*(If there is cross runway) Tower: <YourCallsign> roger, continue taxi to holding point runway <Runway> via <TawiWays>.");
            checkedListBox1.Items.Add("*<YourCallsign>: continue taxi to holding point runway <Runway> via <TaxiWays>.");
            checkedListBox1.Items.Add("Tower: <YourCallsign>, cross runway <Runway> on the other side *(nomral terms) contact <GroundTower> apron <CommFreq>.");
            checkedListBox1.Items.Add("<YourCallsign>: Passing <Runway> after crossing runway *will contact <CommFreq> <YourCallsign>, thank you.");
            checkedListBox1.Items.Add("Thrust Levers");
            checkedListBox1.Items.Add("Auto-Brake");
            checkedListBox1.Items.Add("Speed Brakes");
            checkedListBox1.Items.Add("Brakes");
            checkedListBox1.Items.Add("Auto-Pilot");
            checkedListBox1.Items.Add("Landing Clearance");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.ScrollAlwaysVisible = false;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.HorizontalExtent = 600;
            checkedListBox1.Items.Add("<YourCallsign>: <GroundTower> ground good day, <YourCallsign> at <YourInstantTaxiWay>, with you.");
            checkedListBox1.Items.Add("Ground: <YourCallsign> <GroundTower> apron good day, taxi via <TaxiWays>, stand <Gate>.");
            checkedListBox1.Items.Add("<YourCallsign>: Taxi to stand <Gate> via <TaxiWays>, <YourCallsign>.");
            checkedListBox1.Items.Add("<YourCallsign>: (when you reach to gate) <YourCallsign> on blocks.");
            checkedListBox1.Items.Add("Ground: <YourCallsign> roger welcome to <GroundTower> switching UNICOM <CommFreq> is approved, tschüss.");
            checkedListBox1.Items.Add("Speed Brakes");
            checkedListBox1.Items.Add("Lighting");
            checkedListBox1.Items.Add("Transponder");
            checkedListBox1.Items.Add("Flaps Retracted");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.ScrollAlwaysVisible = false;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Items.Add("Parking Brake");
            checkedListBox1.Items.Add("Throttles");
            checkedListBox1.Items.Add("Fuel Control Switches");
            checkedListBox1.Items.Add("De-Ice");
            checkedListBox1.Items.Add("Flight Director");
            checkedListBox1.Items.Add("Master Switch");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox1, "Free Checklists" + "\n" + "The web's largest collection of checklists.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process proc1 = new Process();
            proc1.StartInfo.UseShellExecute = true;
            proc1.EnableRaisingEvents = false;
            proc1.StartInfo.FileName = "http://www.freechecklists.net/";
            proc1.Start();
            proc1.Close();
            proc1.Dispose();
        }
        
    }
}
