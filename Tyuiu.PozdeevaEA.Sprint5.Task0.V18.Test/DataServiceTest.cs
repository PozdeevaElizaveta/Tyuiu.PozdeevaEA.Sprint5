using System.IO;
using Tyuiu.PozdeevaEA.Sprint5.Task0.V18.Lib;

namespace Tyuiu.PozdeevaEA.Sprint5.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\lpozd\source\repos\Tyuiu.PozdeevaEA.Sprint5\Tyuiu.PozdeevaEA.Sprint5.Task0.V18\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool file = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, file);
        }
    }
}
