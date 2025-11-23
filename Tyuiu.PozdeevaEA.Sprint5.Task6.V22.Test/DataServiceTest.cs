using Tyuiu.PozdeevaEA.Sprint5.Task6.V22.Lib;
namespace Tyuiu.PozdeevaEA.Sprint5.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\lpozd\source\repos\Tyuiu.PozdeevaEA.Sprint5\Tyuiu.PozdeevaEA.Sprint5.Task6.V22\bin\Debug\net8.0\InPutDataFileTask6V22.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
