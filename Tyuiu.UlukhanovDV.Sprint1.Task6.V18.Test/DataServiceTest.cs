﻿using Tyuiu.UlukhanovDV.Sprint1.Task6.V18.Lib;
namespace Tyuiu.UlukhanovDV.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()

        {
            string strTest = "122";
            DataService ds = new DataService();
            bool res = ds.CheckNumber(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
