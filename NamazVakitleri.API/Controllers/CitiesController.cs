using NamazVakitleri.API.DAL;
using NamazVakitleri.API.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NamazVakitleri.API.Controllers
{
    [RoutePrefix("api/cities")]
    public class CitiesController : ApiController
    {
        [Route("{countryid}")]
        [HttpGet]
        public HttpResponseMessage GetCities(int countryid)
        {
            HttpResponseMessage response = null;
            Error error = new Error();

            try
            {
                List<M_Cities> Cities = DbConnection.GetCities(countryid);
                response = Helper.GetJson(Request, Cities);
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
