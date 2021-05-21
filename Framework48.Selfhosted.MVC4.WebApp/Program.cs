using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Framework48.Selfhosted.MVC4.WebLib;

namespace Framework48.Selfhosted.MVC4.WebApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello from .NET Framework 4.8 & MVC4");

            string virtualDir = "/webapp";
            string relativePath = ""; 
            const int port = 8080;

            AppHost.HostAndSetup<MvcApplication>(virtualDir, relativePath, port);

            Console.WriteLine($"Listening on http://localhost:{port}/{relativePath}");
            Console.ReadLine();
        }
    }
}