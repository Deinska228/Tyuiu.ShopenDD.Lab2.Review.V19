using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ShopenDD.Lab2.Review.V19.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = stopValue - startValue + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (double x = startValue; x <= stopValue; x++)
            {
               
                if (x == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                     y = Math.Pow(Math.Cos(Math.Sin(2 / x)), 2) + Math.Pow(x, 2);
                     valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}
