using NamazVakitleri.API.DAL;
using NamazVakitleri.API.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NamazVakitleri.API.Controllers
{
    [RoutePrefix("api/times")]
    public class TimesController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetTimes(HttpRequestMessage request)
        {
            HttpResponseMessage response = null;
            string requestBody = request.Content.ReadAsStringAsync().Result;

            M_TimesRequest timesRequest = JsonConvert.DeserializeObject<M_TimesRequest>(requestBody);


            Error error = new Error();

            try
            {
                List<M_Districts> Districts = DbConnection.GetTimes(timesRequest);
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
