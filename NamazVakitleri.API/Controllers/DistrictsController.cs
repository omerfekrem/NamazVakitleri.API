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
    [RoutePrefix("api/districts")]
    public class DistrictsController : ApiController
    {
        [Route("{cityId}")]
        [HttpGet]
        public HttpResponseMessage GetDistricts(int cityId)
        {
            HttpResponseMessage response = null;
            Error error = new Error();

            try
            {
                List<M_Districts> Districts = DbConnection.GetDistricts(cityId);
                response = Helper.GetJson(Request, Districts);
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
