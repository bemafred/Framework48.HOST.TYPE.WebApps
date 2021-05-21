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

            // TODO: Extract virtual directory from assembly path so it will work no matter where it happen to be located.
            const string virtualDir = @"D:\src\git\bemafred\Framework48.HOST.TYPE.WebApps\Framework48.Selfhosted.MVC4.WebLib\";
            const string relativePath = ""; // No leading '/' please...
            const int port = 8080;

            AppHost.HostAndSetup<MvcApplication>(virtualDir, relativePath, port);

            Console.WriteLine($"Listening on http://localhost:{port}/{relativePath}");
        }
    }
}