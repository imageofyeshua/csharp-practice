using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistanceConverter
{
    public class FeetConverter
    {
        private const double ratio = 0.3048;

        public static double FromMeter(double meter)
        {
            return meter / ratio;
        }

        public static double ToMeter(double feet)
        {
            return feet * ratio;
        }
    }
}