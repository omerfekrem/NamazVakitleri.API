using NamazVakitleri.API.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NamazVakitleri.API.DAL
{
    public static class DbConnection
    {
        static string connectionString = @"Data Source=.;Initial Catalog=Namaz;Integrated Security=True;";
        public static List<M_Countries> GetCountries()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("Select * From Ulkeler", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt.AsEnumerable().Select(x => new M_Countries 
                    { 
                        UlkeID = x.Field<int>("ulke_id")
                        ,UlkeAdi = x.Field<string>("ulke_adi")
                        ,UlkeAdiEn = x.Field<string>("ulke_adi_en")
                    }).ToList();
                }

            }
        }

        public static List<M_Cities> GetCities(int countryId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("Select * From Sehirler Where ulke_id =" + countryId, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt.AsEnumerable().Select(x => new M_Cities
                    {
                        SehirId = x.Field<int>("sehir_id")
                        ,
                        SehirAdiEn = x.Field<string>("sehir_adi_en")
                        ,
                        SehirAdi = x.Field<string>("sehir_adi")
                        ,
                        UlkeId = x.Field<int>("ulke_id")
                    }).ToList();
                }

            }
        }

        public static List<M_Districts> GetDistricts(int cityId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("Select * From Ilceler Where sehir_id =" + cityId, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt.AsEnumerable().Select(x => new M_Districts
                    {
                        ilceAdi = x.Field<string>("ilce_adi")
                        ,
                        ilceAdiEn = x.Field<string>("ilce_adi_en")
                        ,
                        ilceId = x.Field<int>("ilce_id")
                        ,
                        sehirId = x.Field<int>("sehir_id")
                    }).ToList();
                }

            }
        }

        public static List<M_TimesResponse> GetTimes(M_TimesRequest timesRequest)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("Select * From Vakitler Where ilce_id =" + ilceId, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt.AsEnumerable().Select(x => new M_TimesResponse
                    {
                        GunesDogus = x.Field<string>("gunes_dogus"),
                        AyinSekliUrl = x.Field<string>("ayin_sekli_url"),
                        Aksam = x.Field<string>("aksam"),
                        Gunes = x.Field<string>("gunes"),
                        KibleSaati = x.Field<string>("kible_saati"),
                        GunesBatis = x.Field<string>("gunes_batis"),
                        HicriTarihKisa = x.Field<string>("hicri_tarih_kisa"),
                        HicriTarihKisaIso8601 = x.Field<string>("hicri_tarih_kisa_iso8601"),
                        HicriTarihUzun = x.Field<string>("hicri_tarih_uzun"),
                        HicriTarihUzunIso8601 = x.Field<string>("hicri_tarih_uzun_iso8601"),
                        Ikindi = x.Field<string>("ikindi"),
                        IlceId = x.Field<string>("ilce_id"),
                        Imsak = x.Field<string>("imsak"),
                        MiladiTarihKisa = x.Field<string>("miladi_tarih_kisa"),
                        MiladiTarihKisaIso8601 = x.Field<string>("miladi_tarih_kisa_iso8601"),
                        MiladiTarihUzun = x.Field<string>("miladi_tarih_uzun"),
                        MiladiTarihUzunIso8601 = x.Field<string>("miladi_tarih_uzun_iso8601"),
                        Ogle = x.Field<string>("ogle"),
                        Yatsi = x.Field<string>("yatsi")
                    }).ToList();
                }

            }
        }


    }
}