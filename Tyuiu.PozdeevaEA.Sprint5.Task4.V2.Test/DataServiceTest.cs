using Tyuiu.PozdeevaEA.Sprint5.Task4.V2.Lib;
namespace Tyuiu.PozdeevaEA.Sprint5.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\lpozd\AppData\Local\Temp\tmpxhjsb5.tmp";
            FileInfo fileInfo = new FileInfo(path);
            bool file = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, file);
        }
    }
}
