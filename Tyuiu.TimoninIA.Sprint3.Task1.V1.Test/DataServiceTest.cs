using Tyuiu.TimoninIA.Sprint3.Task1.V1.Lib;
namespace Tyuiu.TimoninIA.Sprint3.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 5.311;

            Assert.AreEqual(wait, res);
        }
    }
}