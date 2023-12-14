using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mondentfernung
{
    public class Mondreise
    {
        double speedKmh;

        public Mondreise(double speed)
        {
            speedKmh = speed;
        }

        // Methoden
        public double GetTravelDurationDays()
        {
            return GetTravelDurationHours() / 24;
        }
        public double GetTravelDurationHours() 
        {
           return 385000 / speedKmh;
          
        }
    }
}

