using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NamazVakitleri.API.Entity
{
    public class M_Districts
    {
        public int ilceId { get; set; }
        public string ilceAdi { get; set; }
        public string ilceAdiEn { get; set; }
        public int sehirId { get; set; }
    }
}