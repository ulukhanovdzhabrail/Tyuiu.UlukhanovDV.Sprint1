﻿using Tyuiu.UlukhanovDV.Sprint1.Task3.V5.Lib;
namespace Tyuiu.UlukhanovDV.Sprint1.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()

        {
            DataService ds = new DataService();
            double x = 120.0;
            double y = 3.5;
            double wait = 420.0;
            var res = ds.DistanceLength(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
