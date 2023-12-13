using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Würfel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Erzeuge eine zufällige Zahl zwischen 1 und 6
            int zufall = new Random().Next(1, 7);

            // Setze den Wert im Label
            label1.Text = zufall.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
