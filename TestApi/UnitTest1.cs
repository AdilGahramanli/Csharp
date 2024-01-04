using System.Security.Cryptography.X509Certificates;
using ApiRequestLibrary;
using OpenDataProject;

namespace TestApi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            FakeRequest fake = new FakeRequest();
            MetroApi target = new MetroApi(fake);
            List<LineData> result = target.jsonFormatServerResponse();



        }
    }
}