using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using Lab_3.Models;
using Newtonsoft.Json.Linq;

namespace Lab_3.Controllers
{
    public class TSController : ApiController
    {
        TelephoneDictionary telephoneDictionary = new TelephoneDictionary();

        [HttpGet]
        public HttpResponseMessage Index()
        {
            HttpResponseMessage rm = new HttpResponseMessage();
            rm.Content = new StringContent(telephoneDictionary.getAllString(), Encoding.UTF8, "application/json");
            return rm;
        }

        [HttpPost]
        public HttpResponseMessage Post(HttpRequestMessage request)
        {
            var body = request.Content;
            string json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);

            telephoneDictionary.insert(Convert.ToString(data.surname), Convert.ToInt32(data.number));

            HttpResponseMessage rm = new HttpResponseMessage();
            rm.Content = new StringContent("OK");
            return rm;
        }

        [HttpPut]
        public HttpResponseMessage Put(HttpRequestMessage request)
        {
            var body = request.Content;
            string json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);

            telephoneDictionary.update(Convert.ToInt32(data.id), Convert.ToString(data.surname), Convert.ToInt32(data.number));

            HttpResponseMessage rm = new HttpResponseMessage();
            rm.Content = new StringContent("OK");
            return rm;
        }

        [HttpDelete]
        public HttpResponseMessage Del(HttpRequestMessage request)
        {
            var body = request.Content;
            string json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);

            telephoneDictionary.delete(Convert.ToInt32(data.id));

            HttpResponseMessage rm = new HttpResponseMessage();
            rm.Content = new StringContent("OK");
            return rm;
        }
    }
}
