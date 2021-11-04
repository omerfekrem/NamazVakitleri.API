using NamazVakitleri.API.DAL;
using NamazVakitleri.API.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace NamazVakitleri.API.Controllers
{
    [RoutePrefix("api/countries")]
    public class CountriesController : System.Web.Http.ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetCountries()
        {
            HttpResponseMessage response = null;
            Error error = new Error();

            try
            {
                List<M_Countries> Countries = DbConnection.GetCountries();
                response = Helper.GetJson(Request, Countries);
            }
            catch (Exception ex)
            {
                error.error_code = 404;
                error.error_message = "Bir hata oluştu.";
                response = Helper.GetJson(Request, error);
            }

            return response;
        }
    }
}