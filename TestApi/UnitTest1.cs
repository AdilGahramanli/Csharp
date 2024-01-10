using System.Globalization;
using System.Security.Cryptography.X509Certificates;

using ApiRequestLibrary;


namespace TestApi
{
    [TestClass]
    public class UnitTest1
    {
        private static double Lat;
        private static double Lon;
        private static int Distance;
        public string url = String.Format(CultureInfo.InvariantCulture, "https://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=true", Lat, Lon, Distance);

        FakeRequest fake = new FakeRequest();
        
        MetroApi metro_api = new MetroApi();
        /*List<LineData> result = target.jsonFormatServerResponse();*/
        Request request = new Request();

        /**//*private const string Expected = fake.requestUrl() ;*/
        [TestMethod]
        public void TestWebResponse()
        {
            MetroApi target = new MetroApi(fake);
            if (Lat == 5.731199161564558 && Lon== 45.18430860448526 && Distance == 400) {

                Assert.AreEqual(metro_api.GetLines().Count, 12);
            }

            

           /* Assert.AreEqual(Expected,  result);*/

        }
        
        public void TestUrlDatasType ()
        {
            if(Lon.GetType() != typeof(double)) { Console.WriteLine("Longitude format error"); }
            if(Lat.GetType() != typeof(double)) { Console.WriteLine("Latitude format error"); }
            if(Distance.GetType() != typeof(int)) { Console.WriteLine("Distance format error"); } 
        }

        public void TestStringFormat () 
        {
            Assert.IsTrue(request.requestUrl(url).GetType() == typeof(string));
           
        }
    }
}