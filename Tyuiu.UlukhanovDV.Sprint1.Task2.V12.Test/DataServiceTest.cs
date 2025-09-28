using Tyuiu.UlukhanovDV.Sprint1.Task2.V12.Lib;
namespace Tyuiu.UlukhanovDV.Sprint1.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()

        {
            DataService ds = new DataService();
            int value = 1;
            int valueTwo = 1;
            int valueThree = 1;
            var res = ds.CalculateParallelepipedVolume(value, valueTwo, valueThree);   
            Assert.AreEqual(1, res);
               
        }
    }
}
