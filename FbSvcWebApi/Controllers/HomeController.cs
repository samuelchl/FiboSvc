using System;
using System.Web.Http;
using Logic;

namespace FbSvcWebApi.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public int Fibonacci(int n)
        {

            return Mth.CalculateFibonacci(n);
        }

        [HttpPost]
        public string XmlToJson(string xmlInput)
        {
            return WebUtils.XmlToJson(xmlInput);
        }
    }
}
