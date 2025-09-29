using Tyuiu.UlukhanovDV.Sprint1.Task1.V14.Lib;
namespace Tyuiu.UlukhanovDV.Sprint1.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 10.0;
            double b = 10.0;
            double c = 10.0;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(10.5, res);

        }
    }
}
