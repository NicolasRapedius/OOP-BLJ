using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mondentfernung
{
    public partial class Form1 : Form
    {
        private const double EntfernungErdeMond = 385000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Reisebox_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double geschwindigkeit;
            if (double.TryParse(textBox1.Text, out geschwindigkeit) && geschwindigkeit > 0)
            {
                double reisedauerInStunden = EntfernungErdeMond / geschwindigkeit;
                if (radioButton2.Checked) // Stunden
                {
                    textBox2.Text = $" {reisedauerInStunden} Stunden";
                }
                else if (radioButton1.Checked) // Tage
                {
                    double reisedauerInTagen = reisedauerInStunden / 24;
                    textBox2.Text = $" {reisedauerInTagen} Tage";
                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige Geschwindigkeit ein.");
            }
        }

    }
}
