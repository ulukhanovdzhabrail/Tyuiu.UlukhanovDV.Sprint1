using Tyuiu.UlukhanovDV.Sprint1.Task4.V11.Lib;
namespace Tyuiu.UlukhanovDV.Sprint1.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double wait = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
