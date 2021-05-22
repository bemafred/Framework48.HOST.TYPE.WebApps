using System;
using System.Collections.Generic;
using System.IO;
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

            string virtualDir = "/";
            string relativePath = $"app.publish"; 
            const int port = 44333;

            AppHost.HostAndSetup<MvcApplication>(virtualDir, relativePath, port);

            Console.WriteLine($"Listening on http://localhost:{port}{virtualDir}");
            Console.ReadLine();
        }
    }
}