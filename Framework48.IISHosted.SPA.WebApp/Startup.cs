using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;

[assembly: OwinStartup(typeof(Framework48.IISHosted.SPA.WebApp.Startup))]

namespace Framework48.IISHosted.SPA.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
