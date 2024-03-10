using OTS2023_ConventorApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnMass_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            grbxTime.Visible = false;
            grbxSegment.Visible = true;
            label1.Text = "Pounds";
            label2.Text = "Kg";
        }

        private void rbtnLength_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            grbxSegment.Visible = true;
            grbxTime.Visible = false;
            label1.Text = "Feet";
            label2.Text = "M";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnMass.Checked)
            {
                MassConverter converter = new MassConverter();
                if (rbtnArray.Checked)
                {
                    try
                    {
                        textBox2.Text = converter.ConvertArray(textBox1.Text).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        textBox2.Text = converter.Convert(Double.Parse(textBox1.Text)).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if (rbtnLength.Checked)
            {
                LengthConverter converter = new LengthConverter();

                if (rbtnArray.Checked)
                {
                    try
                    {
                        textBox2.Text = converter.ConvertArray(textBox1.Text).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        textBox2.Text = converter.Convert(Double.Parse(textBox1.Text)).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if(rbtnTime.Checked)
            {
                TimeConverter converter = new TimeConverter();

                if (rbtnHours.Checked)
                {
                    try
                    {
                        textBox2.Text = converter.ConvertHours(Double.Parse(textBox1.Text)).ToString();
                    }

                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if(rbtnMinutes.Checked)
                {
                    try
                    {
                        textBox2.Text = converter.ConvertMinutes(Double.Parse(textBox1.Text)).ToString();
                    }

                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if(rbtnSeconds.Checked)
                {
                    try
                    {
                        textBox2.Text = converter.ConvertSeconds(Double.Parse(textBox1.Text)).ToString();
                    }

                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if(rbtnMoney.Checked)
            {
                MoneyConverter converter = new MoneyConverter();

                if (rbtnArray.Checked)
                {
                    try
                    {
                        textBox2.Text = converter.ConvertArray(textBox1.Text).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        textBox2.Text = converter.ConvertMoney(Double.Parse(textBox1.Text)).ToString();
                    }

                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
                }
            }

            else if (rbtnCustomMoney.Checked)
            {
                CustomMoneyConverter converter = new CustomMoneyConverter();
                try
                {
                    textBox2.Text = converter.ConvertCustomMoney(textBox1.Text).ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rbtnMoney_CheckedChanged(object sender, EventArgs e)
        {

            grbxTime.Visible = false;
            grbxSegment.Visible = true;
            label1.Text = "EUR";
            label2.Text = "RSD";

        }

        private void rbtnTime_CheckedChanged(object sender, EventArgs e)
        {
            grbxSegment.Visible = false;
            grbxTime.Visible = true;
            label1.Text = "Days";

            if (rbtnHours.Checked)
            {
                label2.Text = "Hours";
            }

            else if (rbtnMinutes.Checked)
            {
                label2.Text = "Minutes";
            }

            else 
            {
                label2.Text = "Seconds";
            }
        }

        private void rbtnHours_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Hours";
        }

        private void rbtnMinutes_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Minutes";
        }

        private void rbtnSeconds_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Seconds";
        }

        private void rbtnCustomMoney_CheckedChanged(object sender, EventArgs e)
        {
            grbxSegment.Visible = false;
            label1.Text = "Custom expression";
            label2.Text = "Result";

        }

    }
}
