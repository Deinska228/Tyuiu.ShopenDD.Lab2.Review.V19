using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShopenDD.Lab2.Review.V19.Lib;

namespace Tyuiu.ShopenDD.Lab2.Review.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] valueWaitArray = new double[len];

            valueWaitArray[0] = 25.86;
            valueWaitArray[1] = 16.79;
            valueWaitArray[2] = 9.66;
            valueWaitArray[3] = 4.44;
            valueWaitArray[4] = 1.38;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = 1.38;
            valueWaitArray[7] = 4.44;
            valueWaitArray[8] = 9.66;
            valueWaitArray[9] = 16.79;
            valueWaitArray[10] = 25.86;


            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
