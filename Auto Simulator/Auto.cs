using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Simulator
{
    public class Auto
    {
        public int AktuelleGeschwindigkeit { get; set; }
        public int AktuellerGang {  get; set; }
        public bool IstMotorGestartet { get; set; }
        public string Marke {  get; set; }
        public int PS {  get; set; }
        public double TankFuellstand { get; set; }

        public Auto(string m, int p) 
        {
            Marke = m;
            PS = p;
        }
        public override string ToString()
        {
            return this.Marke;
        }
        public void auftanken()
        {
            TankFuellstand += 20;

            if (TankFuellstand > 100)
            {
                TankFuellstand = 100;
                return;
            }
        }
        public void GibGas()
        {
            {

                double grundbeschleunigung = PS * 0.03;
                double beschleunigungsFaktor = 1 - (AktuelleGeschwindigkeit / 200.0);

                int neueGeschwindigkeit = (int)Math.Round(AktuelleGeschwindigkeit + grundbeschleunigung * beschleunigungsFaktor);

                AktuelleGeschwindigkeit = Math.Min(neueGeschwindigkeit, PS);

                TankFuellstand -= (PS * 0.005 + AktuelleGeschwindigkeit * 0.0005);
                if (TankFuellstand < 0) TankFuellstand = 0;
            }

            if (TankFuellstand == 0)
            {
                IstMotorGestartet = false;
                AktuelleGeschwindigkeit = 0;
            }


        }
       
    }
}
