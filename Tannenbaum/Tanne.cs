using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    public class Tanne
    {
        public int Stammbreite { get; set; }
        public int Stammhoehe { get; set; }
        public int Kronenhoehe { get; set; }
        public string Zeichnung { get; set; }
        public Tanne(int b,int sh, int kh ) 
        {
            Stammbreite = b;
            Stammhoehe = sh;
            Kronenhoehe = kh;
        }
         public void Zeichne()
        {
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= Kronenhoehe; i++)
                {
                    for (int j = 1; j <= Kronenhoehe - i; j++)
                    {
                        sb.Append(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        sb.Append("*");
                    }
                    sb.AppendLine();
                }

                for (int i = 0; i < Stammhoehe; i++)
                {
                    for (int j = 1; j <= Kronenhoehe - Stammbreite / 2; j++)
                    {
                        sb.Append(" ");
                    }
                    for (int k = 1; k <= Stammbreite; k++)
                    {
                        sb.Append("*");
                    }
                    sb.AppendLine();
                }
                Zeichnung =  sb.ToString();
         }
    }
}
