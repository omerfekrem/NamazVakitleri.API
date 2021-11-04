using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NamazVakitleri.API.Entity
{
    public class Error
    {
        public string success_message { get; set; }
        public string error_message { get; set; }
        public int error_code { get; set; }
    }
}