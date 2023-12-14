using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechteck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int tbreite = Convert.ToInt32(textbreite.Text);
            int thoehe = Convert.ToInt32(texthoehe.Text);


            Rechteck rechteck = new Rechteck();
            rechteck.Width = tbreite;
            rechteck.Height = thoehe; 

            double flaeche = rechteck.GetArea();

            textBox3.Text = flaeche.ToString();
        }


        private void Beenden_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
