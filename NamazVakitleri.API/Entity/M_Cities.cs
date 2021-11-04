using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NamazVakitleri.API.Entity
{
    public class M_Cities
    {
        public int SehirId { get; set; }
        public string SehirAdi { get; set; }
        public string SehirAdiEn { get; set; }
        public int UlkeId { get; set; }
    }
}