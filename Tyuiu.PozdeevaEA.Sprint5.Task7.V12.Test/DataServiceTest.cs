using Tyuiu.PozdeevaEA.Sprint5.Task7.V12.Lib;
namespace Tyuiu.PozdeevaEA.Sprint5.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"С:\DataSprint5\InPutDataFileTask7V12.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool file = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, file);
        }
    }
}
