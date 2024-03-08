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
            label1.Text = "Pounds";
            label2.Text = "Kg";
        }

        private void rbtnLength_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Feet";
            label2.Text = "M";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnMass.Checked)
            {
                MassConverter converter = new MassConverter();

                try
                {
                    textBox2.Text = converter.Convert(Double.Parse(textBox1.Text)).ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (rbtnLength.Checked)
            {
                LengthConverter converter = new LengthConverter();

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
    }
}
