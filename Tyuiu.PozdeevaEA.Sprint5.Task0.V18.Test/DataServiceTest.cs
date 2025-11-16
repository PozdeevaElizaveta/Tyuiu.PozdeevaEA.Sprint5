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
            string path = @"C:\Users\lpozd\AppData\Local\Temp\tmpwgm5h2.tmp";
            FileInfo fileInfo = new FileInfo(path);
            bool file = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, file);
        }
    }
}
