using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Framework48.IISHosted.SPA.WebApp.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}