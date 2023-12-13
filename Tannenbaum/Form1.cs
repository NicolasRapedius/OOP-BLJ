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
        public int Stammbreite { get; set; }
        public int Stammhoehe { get; set; }
        public int Kronenhoehe { get; set; }
        public string Zeichnung { get; private set; }

        



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int Kronenhoehe = Convert.ToInt32(textBoxKronenHoehe.Text.ToString());
            int Stammbreite = Convert.ToInt32(textBoxStammBreite.Text.ToString());
            int Stammhoehe = Convert.ToInt32(textBoxStammHoehe.Text.ToString());

            string zeichnung = Zeichne(Kronenhoehe, Stammbreite, Stammhoehe);
            textBoxAusgabe.Text = zeichnung;
        }

        private string Zeichne(int höheKrone, int breiteStamm, int höheStamm)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= höheKrone; i++)
            {
                for (int j = 1; j <= höheKrone - i; j++)
                {
                    sb.Append(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
            }

            for (int i = 0; i < höheStamm; i++)
            {
                for (int j = 1; j <= höheKrone - breiteStamm / 2; j++)
                {
                    sb.Append(" ");
                }
                for (int k = 1; k <= breiteStamm; k++)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}

