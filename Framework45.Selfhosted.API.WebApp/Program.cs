using System;
using System.Net.Http;
//using Microsoft.Owin.Hosting;

using HostingWebApp = Microsoft.Owin.Hosting.WebApp;

namespace Framework45.Selfhosted.API.WebApp
//namespace OwinSelfhostSample
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello from .NET Framework 4.5");

            string baseAddress = "http://localhost:10281/";

            // Start OWIN host
            using (HostingWebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpCient and make a request to api/values
                HttpClient client = new HttpClient();

                HttpResponseMessage response = client.GetAsync(baseAddress + "api/values").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }

            Console.ReadLine();
        }
    }
}
