using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiRequestLibrary
{
    public class Request:IRequest { 
    public string requestUrl(string url)
    {

        WebRequest request = WebRequest.Create(url);

        /*Console.WriteLine("\nThe Timeout time of the request before setting is : {0} milliseconds", request.Timeout);*/
        request.Method = "GET";
        WebResponse webResponse = request.GetResponse();
        Stream dataStream = webResponse.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();

        return responseFromServer;

    }
}
}
