using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UlukhanovDV.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double res = (x - Math.Floor(x)) * 10;
            return (int)Math.Floor(res); 

            
        }
    }
}
