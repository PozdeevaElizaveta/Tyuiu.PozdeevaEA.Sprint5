using Tyuiu.PozdeevaEA.Sprint5.Task7.V12.Lib;
namespace Tyuiu.PozdeevaEA.Sprint5.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\lpozd\source\repos\Tyuiu.PozdeevaEA.Sprint5\Tyuiu.PozdeevaEA.Sprint5.Task7.V12\bin\Debug\net8.0\InPutDataFileTask7V12.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool file = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, file);
        }
    }
}
