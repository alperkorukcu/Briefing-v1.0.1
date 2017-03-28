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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0, value1 = 360, value2 = 600; double crosswind = 0, headwind = 0, tailwind = 0;

            if (Int32.Parse(textBox1.Text) > value1 | textBox1.Text == "")
            {
                textBox1.Text = "";
                counter++;
            }

            if (Int32.Parse(textBox2.Text) > value1 | textBox1.Text == "")
            {
                textBox2.Text = "";
                counter++;
            }

            if (Int32.Parse(textBox3.Text) > value2 | textBox1.Text == "")
            {
                textBox3.Text = "";
                counter++;
            }

            if (counter == 0)
            {
                crosswind = Math.Sin((Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text)) * (Math.PI / 180)) * Int32.Parse(textBox3.Text);

                headwind = Math.Cos((Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text)) * (Math.PI / 180)) * Int32.Parse(textBox3.Text);

                tailwind = -(Math.Sin((Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text)) * (Math.PI / 180)) * Int32.Parse(textBox3.Text));

                label5.Text = "Crosswind → " + Math.Round(crosswind, 3).ToString();

                label6.Text = "Headwind → " + Math.Round(headwind, 3).ToString();

                label7.Text = "Tailwind → " + Math.Round(tailwind, 3).ToString();
            }
            else
            { /* do nothing */ }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "  ^ [0-9]"))
                {
                    textBox4.Text = "";
                }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "  ^ [0-9]"))
                {
                    textBox5.Text = "";
                }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "  ^ [0-9]"))
                {
                    textBox6.Text = "";
                }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            checkBox4.Checked = true;
            checkBox5.Checked = false;

            textBox4.Enabled = true;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

            textBox7.Enabled = true;
            textBox8.Enabled = false;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox4.Enabled = true;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            if(checkBox1.Checked == false)
            {
                textBox4.Enabled = false;
                textBox4.Text = "";
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox5.Enabled = true;
                textBox4.Enabled = false;
                textBox6.Enabled = false;
                textBox5.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
            if (checkBox2.Checked == false)
            {
                textBox5.Enabled = false;
                textBox5.Text = "";
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox6.Enabled = true;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            if (checkBox3.Checked == false)
            {
                textBox6.Enabled = false;
                textBox6.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true & textBox4.Text != "")
            {
                textBox5.Text = Math.Round((double.Parse(textBox4.Text) * 2.2046228), 3).ToString();
                textBox6.Text = Math.Round((double.Parse(textBox4.Text) * 0.27557785), 3).ToString();
            }
            else if(checkBox2.Checked == true & textBox5.Text != "")
            {
                textBox4.Text = Math.Round((double.Parse(textBox5.Text) * 0.45359), 3).ToString();
                textBox6.Text = Math.Round((double.Parse(textBox5.Text) * 0.125), 3).ToString();
            }
            else if(checkBox3.Checked == true & textBox6.Text != "")
            {
                textBox4.Text = Math.Round((double.Parse(textBox6.Text) * 3.62873), 3).ToString();
                textBox5.Text = Math.Round((double.Parse(textBox6.Text) * 8), 3).ToString();
            }
            else
            { /*do nothing*/}
        }

        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked == true)
            {
                textBox7.Enabled = true;
                textBox8.Enabled = false;

                textBox7.Text = "";
                textBox8.Text = "";

                checkBox5.Checked = false;
            }
            if(checkBox4.Checked == false)
            {
                textBox7.Enabled = false;

                textBox7.Text = "";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox5.Checked == true)
            {
                textBox8.Enabled = true;
                textBox7.Enabled = false;

                textBox7.Text = "";
                textBox8.Text = "";
                checkBox4.Checked = false;
            }
            if(checkBox5.Checked == false)
            {
                textBox8.Enabled = false;

                textBox8.Text = "";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(checkBox4.Checked == true & textBox7.Text != "")
            {
                textBox8.Text = Math.Round(((double.Parse(textBox7.Text) * 1.8) + 32), 3).ToString();
            }
            else if (checkBox5.Checked == true & textBox8.Text != "")
            {
                textBox7.Text = Math.Round(((double.Parse(textBox8.Text) - 32) * 0.55555555555), 3).ToString();
            }
            else
            { /*do nothing*/ }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayac = 0;

            if(textBox9.Text == "")
            {
                sayac++;
            }
            if(textBox10.Text == "")
            {
                sayac++;
            }
            if(textBox11.Text == "")
            {
                sayac++;
            }
            if(textBox12.Text == "")
            {
                sayac++;
            }

            if(sayac == 0)
            {
                label23.Text = "Descent Angle → " + Math.Round(((double.Parse(textBox9.Text) - double.Parse(textBox10.Text)) / double.Parse(textBox11.Text) / 100), 2).ToString() + "°";
                label24.Text = "Descent Rate  → " + Math.Round((double.Parse(textBox12.Text) / 60 * ((double.Parse(textBox9.Text) - double.Parse(textBox10.Text)) / double.Parse(textBox11.Text)))).ToString() + "ft/min";
            }
            else
            { /* do nothing */ }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayici = 0;

            if (textBox13.Text == "")
            {
                sayici++;
            }
            if(textBox14.Text == "")
            {
                sayici++;
            }

            if(sayici == 0)
            {
                label34.Text = "Drift → " + Math.Round((60 / double.Parse(textBox13.Text) * double.Parse(textBox14.Text)), 2).ToString() + "°";
            }
            else
            { /* do nothing */ }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int flag = 0;

            if(textBox15.Text == "")
            {
                flag++;
            }
            if(textBox16.Text == "")
            {
                flag++;
            }

            if(flag == 0)
            {
                if (((double.Parse(textBox15.Text) / 60) - 2) <= 0)
                {
                    label39.Text = "Lead Distance → 0.00 nm";
                }
                else
                {
                    label39.Text = "Lead Distance → " + Math.Round(((double.Parse(textBox15.Text) / 60) - 2), 2).ToString() + "nm";
                }
                label40.Text = "On an arc ↓";
                if ((60 / double.Parse(textBox16.Text)) <= 0)
                {
                    label41.Text = "Radial/NM     → 0.00";
                }
                else
                {
                    label41.Text = "Radial/NM     → " + Math.Round((60 / double.Parse(textBox16.Text)), 2).ToString();
                }
                if ((((double.Parse(textBox15.Text) / 60) - 2) * (60 / double.Parse(textBox16.Text))) <= 0)
                {
                    label42.Text = "Radial Lead   → 0.00";
                }
                else
                {
                    label42.Text = "Radial Lead   → " + Math.Round((((double.Parse(textBox15.Text) / 60) - 2) * (60 / double.Parse(textBox16.Text))), 2).ToString();
                }
            }
            else
            { /* do nothing */ }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int isaret = 0;

            if(textBox17.Text == "")
            {
                isaret++;
            }
            if(textBox18.Text == "" | double.Parse(textBox18.Text) == 0)
            {
                isaret++;
            }

            if(isaret == 0)
            {
                label48.Text = "VDP distance from Treshold → " + Math.Round((double.Parse(textBox17.Text) / double.Parse(textBox18.Text) / 100), 2).ToString() + "nm";
            }
            else
            { /* do nothing */ }
        }
    }
}
