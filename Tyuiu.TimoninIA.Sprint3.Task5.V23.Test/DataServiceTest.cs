namespace Tyuiu.TimoninIA.Sprint3.Task5.V23.Test;
using Tyuiu.TimoninIA.Sprint3.Task5.V23.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestGetSumSumSeries()
    {
        DataService ds = new();
        Assert.AreEqual(-3653.176, ds.GetSumSumSeries(2, 1, 1, 3, 10));
    }
}