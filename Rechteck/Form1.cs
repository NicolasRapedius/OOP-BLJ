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

            int flaeche = tbreite * thoehe;

            textBox3.Text = flaeche.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Beenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
