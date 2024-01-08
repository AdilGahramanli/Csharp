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
using System.Resources;
using ApiRequestLibrary;





namespace ApiRequestLibrary
{

    public class MetroApi
    {

        private static double lat = 5.731199161564558;
        private static double lon = 45.18430860448526;
        private static int distance = 400;
        public string url = String.Format(CultureInfo.InvariantCulture, "https://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=true", lat, lon, distance);

        private IRequest _request;

        public double Lat { get => lat; set => lat = value; }
        public double Lon { get => lon; set => lon = value; }
        public  int Distance { get => distance; set => distance = value; }

        public MetroApi()
        {
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
            string webResponse = _request.requestUrl(url);


            List<LineData> deserializedLineData = JsonConvert.DeserializeObject<List<LineData>>(webResponse);

            return deserializedLineData;
        }




    }
}
