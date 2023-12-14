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

        Wuerfel w = new Wuerfel();

        public Form1()
        {
            InitializeComponent();
            
        }


        private int letztesErgebnis;
        private int vorherigesErgebnis;

        private void button1_Click(object sender, EventArgs e)
        {
         
            int wurf = w.Werfen();
            labelAktuellerWurf.Text = wurf.ToString();

            vorherigesErgebnis = w.LetzterWurf;

            Letzter.Text = vorherigesErgebnis.ToString();
        }


    }
}
