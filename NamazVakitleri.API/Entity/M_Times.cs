using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NamazVakitleri.API.Entity
{
    public class M_TimesRequest
    {
        public string IlceId { get; set; }
        public string Tarih { get; set; }
    }

    public class M_TimesResponse
    {
        public string Aksam { get; set; }
        public string AyinSekliUrl { get; set; }
        public string Gunes { get; set; }
        public string GunesBatis { get; set; }
        public string GunesDogus { get; set; }
        public string HicriTarihKisa { get; set; }
        public string HicriTarihKisaIso8601 { get; set; }
        public string HicriTarihUzun { get; set; }
        public string HicriTarihUzunIso8601 { get; set; }
        public string Ikindi { get; set; }
        public string Imsak { get; set; }
        public string KibleSaati { get; set; }
        public string MiladiTarihKisa { get; set; }
        public string MiladiTarihKisaIso8601 { get; set; }
        public string MiladiTarihUzun { get; set; }
        public string MiladiTarihUzunIso8601 { get; set; }
        public string Ogle { get; set; }
        public string Yatsi { get; set; }
        public string IlceId { get; set; }
    }
}