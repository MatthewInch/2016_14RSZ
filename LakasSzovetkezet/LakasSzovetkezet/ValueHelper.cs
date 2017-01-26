using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakasSzovetkezet
{
    public class ValueHelper
    {
        public static int CalculateValue(double size, int radiatiors)
        {
            int result = 0;
            //m2        Ft
            //27,47   4500
            //37,4    6700
            //43,93   6800
            //55,25   9600
            //76,56   13300

            if (size < 37.4)
            {
                result = 4500 ;
            } else if (size <43.93)
            {
                result = 6700;
            } else if (size < 55.25)
            {
                result = 6800;
            }
            else if (size < 76.56)
            {
                result = 9600;
            } else
            {
                result = 13300;
            }

            return result + radiatiors * 100;
        }
    }
}
