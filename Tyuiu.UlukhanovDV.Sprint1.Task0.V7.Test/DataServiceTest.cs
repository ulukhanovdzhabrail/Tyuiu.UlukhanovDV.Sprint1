﻿using Tuyiu.UlukhanovDV.Sprint1.Task0.V7.Lib;
namespace Tuyiu.UlukhanovDV.Sprint1.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(5, res);
        }
    }
}
