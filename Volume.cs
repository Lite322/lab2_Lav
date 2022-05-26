using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Lav
{
    public class Volume
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"> Колличество шаров </param>
        /// <param name="r"> Радиус первого шара </param>
        /// <returns></returns>
        public static double Sum(int n, double r)
        {
            double z = 0;
            for (int i = 0; i < n; i++)
            {
                z += (4 / 3) * Math.PI * Math.Pow(r, 3);
                r += 0.2;
            }
            return z;
        }

        public static double Average(int n, double r)
        {
            double z = Volume.Sum(n, r) / n;
            return z;
        }
    }
}