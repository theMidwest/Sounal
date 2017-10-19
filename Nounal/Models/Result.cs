using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Mvc.Ajax;

namespace Nounal.Models
{
    public class Result
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public IDictionary<string, object> Data { get; }
        = new Dictionary<string, object>();
    }
}
