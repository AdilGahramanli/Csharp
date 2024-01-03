
using System.Net;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text.Json.Serialization;
using Newtonsoft.Json;






// See https://aka.ms/new-console-template for more information
using OpenDataProject;

Console.WriteLine("Hello, World!");

MetroApi requestApi = new MetroApi();

List<LineData> serverResponse = requestApi.jsonFormatServerResponse();

foreach (LineData lineData in requestApi.jsonFormatServerResponse())
{
    Console.WriteLine("id : " + lineData.id);
    Console.WriteLine("name : " + lineData.name);
    Console.WriteLine("lon : " + lineData.lon);
    Console.WriteLine("lat : " + lineData.lat);
    Console.WriteLine("zone : " + lineData.zone);
    foreach(string txt in lineData.lines){ Console.WriteLine(txt); }
}


//Console.WriteLine(requestApi.lineDataObjectList(serverResponse));


