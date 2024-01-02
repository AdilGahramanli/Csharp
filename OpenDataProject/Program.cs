
using System.Net;
using System.Reflection.PortableExecutable;




// See https://aka.ms/new-console-template for more information
using OpenDataProject;
ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
SecurityProtocolType.Tls;
Console.WriteLine("Hello, World!");

OpenDataRequest requestApi = new OpenDataRequest();

Console.WriteLine(requestApi.affichageUrl());

Console.WriteLine(requestApi.requestUrl());
Stream dataStream = requestApi.requestUrl().GetResponseStream();
StreamReader reader = new StreamReader(dataStream);
string responseFromServer = reader.ReadToEnd();
Console.WriteLine(responseFromServer);
reader.Close();
dataStream.Close();





