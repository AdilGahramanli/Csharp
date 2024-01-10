
using System.Net;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using ApiRequestLibrary;




Console.WriteLine("Hello, World!");

MetroApi requestApi = new MetroApi();


foreach (LineData lineData in requestApi.GetLines())
{
    Console.WriteLine("id : " + lineData.id);
    Console.WriteLine("name : " + lineData.name);
    Console.WriteLine("lon : " + lineData.lon);
    Console.WriteLine("lat : " + lineData.lat);
    Console.WriteLine("zone : " + lineData.lines);
    foreach(string txt in lineData.lines){ Console.WriteLine(txt); }
}





