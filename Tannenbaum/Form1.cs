using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaum
{

    public partial class Form1 : Form
    {
       

        



        public Form1()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            int Kronenhoehe = Convert.ToInt32(textBoxKronenHoehe.Text);
            int Stammbreite = Convert.ToInt32(textBoxStammBreite.Text);
            int Stammhoehe = Convert.ToInt32(textBoxStammHoehe.Text);

           Tanne t =  new Tanne(Stammbreite, Stammhoehe, Kronenhoehe);
            t.Zeichne();
            textBoxAusgabe.Text = t.Zeichnung;
        }

        
        
    }
}

