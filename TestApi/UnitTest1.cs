using System.Security.Cryptography.X509Certificates;

using ApiRequestLibrary;

namespace TestApi
{
    [TestClass]
    public class UnitTest1
    {

        private const string Expected = "r�sultat de la requ�te url";
        [TestMethod]
        public void TestWebResponse()
        {


            FakeRequest fake = new FakeRequest();
            MetroApi target = new MetroApi(fake);
            List<LineData> result = target.jsonFormatServerResponse();

           /* Assert.AreEqual(Expected,  result);*/

        }
    }
}