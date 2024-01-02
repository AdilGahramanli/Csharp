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




namespace OpenDataProject
{
    
    public class OpenDataRequest
    {
        
        public static double X = 5.731199161564558;
        public static  double Y = 45.18430860448526;
        public string url = String.Format(CultureInfo.InvariantCulture, "https://data.mobilites-m.fr/api/linesNear/json?x={0}&y={1}&dist=400&details=true", X, Y);

        public WebResponse requestUrl()
        {
            WebRequest request = WebRequest.Create(url);

            /*Console.WriteLine("\nThe Timeout time of the request before setting is : {0} milliseconds", request.Timeout);*/
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            return response;
            
        }

        public string affichageUrl()
        {
            return url;
        }

        
    }
}
