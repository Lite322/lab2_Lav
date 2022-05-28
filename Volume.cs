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
        /// Находит сумму объёмов шаров с радиусами r, r + 0.2, r + 0.4, r + 0.6,...
        /// </summary>
        /// <param name="n"> Колличество шаров </param>
        /// <param name="r"> Радиус первого шара </param>
        /// <returns></returns>
        public static double Sum(int n, double r)
        {
            double z = 0;
            for (int i = 0; i < n; i++)
            {
                z += (4 * Math.PI * Math.Pow(r, 3)) / 3;
                r += 0.2;
            }
            return Math.Round(z, 3); // округление до 3 знаков после запятой
        }

        /// <summary>
        /// Находит среднее значение суммы объёмов шаров
        /// </summary>
        /// <param name="n"> Колличество шаров </param>
        /// <param name="r"> Радиус первого шара </param>
        /// <returns></returns>
        public static double Average(int n, double r)
        {
            double z = Volume.Sum(n, r) / n;
            return Math.Round(z, 3); // округление до 3 знаков после запятой
        }
    }
}