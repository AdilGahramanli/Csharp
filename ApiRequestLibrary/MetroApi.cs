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

        private static double _lat = 5.731199161564558;
        private static double _lon = 45.18430860448526;
        private static int _distance = 400;
        //public string url = String.Format(CultureInfo.InvariantCulture, "https://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=true", _lat, _lon, _distance);

        private IRequest _request;

        public double Lat { get => _lat; set => _lat = value; }
        public double Lon { get => _lon; set => _lon = value; }
        public  int Distance { get => _distance; set => _distance = value; }

        public MetroApi()
        {
            _request = new Request();
        }

        public MetroApi(IRequest request)
        {
            _request = request;
        }




        public List<LineData> JsonFormatServerResponse(string response)
        {

            List<LineData> deserializedLineData = JsonConvert.DeserializeObject<List<LineData>>(response);

            return deserializedLineData;
        }

        public List<LineData> GetLines(double lat, double lon, int distance)
        {
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            string url = MakeUrl(lat, lon, distance);
            //string webResponse = _request.requestUrl(url);
            //return JsonFormatServerResponse(webResponse);
            return GetLines(url);
        }

        public List<LineData> GetLines()
        {
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            string url = MakeUrl();
            //string webResponse = _request.requestUrl(url);
            //return JsonFormatServerResponse(webResponse);
            return GetLines(url);
        }

        private List<LineData> GetLines(string url)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
           
            string webResponse = _request.requestUrl(url);
            return JsonFormatServerResponse(webResponse);
        }

        private string MakeUrl(double lat, double lon, int distance)
        {
            _lat = lat;
            _lon = lon;
            _distance = distance;
            return MakeUrl();
            //string url = String.Format(CultureInfo.InvariantCulture, "https://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=true", _lat, _lon, _distance);
            //return url;
        }

        private string MakeUrl()
        {
            string url = String.Format(CultureInfo.InvariantCulture, "https://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist={2}&details=true", _lat, _lon, _distance);
            return url;
        }
    }
}
