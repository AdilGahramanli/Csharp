using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Globalization;
using System.Security.Principal;
using Newtonsoft.Json;





namespace OpenDataProject
{
    
    public class MetroApi
    {
        
        public static double X = 5.731199161564558;
        public static  double Y = 45.18430860448526;
        public string url = String.Format(CultureInfo.InvariantCulture, "https://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist=400&details=true", X, Y);
        LineData lineData = new LineData();
        private IRequest _request;
        public MetroApi() {
            _request = new Request();
        }

        public MetroApi(IRequest request)
        {
            _request = request;
        }
       

        public List<LineData> jsonFormatServerResponse()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
            SecurityProtocolType.Tls;
            WebResponse webResponse = _request.requestUrl();
            Stream dataStream = webResponse.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            String responseFromServer = reader.ReadToEnd();

            List<LineData> deserializedLineData = JsonConvert.DeserializeObject<List<LineData>>(responseFromServer);

            return deserializedLineData;
        }

        public WebResponse requestUrl()
        {
            WebRequest request = WebRequest.Create(url);

            /*Console.WriteLine("\nThe Timeout time of the request before setting is : {0} milliseconds", request.Timeout);*/
            request.Method = "GET";
            WebResponse response = request.GetResponse();

            return response;

        }

        //public string affichageUrl()
        //{
        //    return url;
        //}




    }
}
