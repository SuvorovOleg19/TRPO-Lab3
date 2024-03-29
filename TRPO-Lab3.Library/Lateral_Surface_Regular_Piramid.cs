﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Lab3.Library
{
    public class Lateral_Surface_Regular_Piramid
    {

        public static double Lateral_Surface_Regular_Piramid_formula(double p,double a)
        {
            if (p <= 0 || a <= 0)
            {
                throw new ArgumentException("Значение параметров должно быть положительным");
            }

            return 0.5 * p * a;
        }
    }
}
