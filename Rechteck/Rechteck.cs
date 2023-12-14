using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    internal class Rechteck
    {

        public Rechteck()
        { 
        
        }

        double height, width;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
            return height * width;
        }
    }
}
