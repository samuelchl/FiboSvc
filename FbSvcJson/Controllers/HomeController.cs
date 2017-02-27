using System;
using System.Web.Http;
using SharedLogic;

namespace FbSvcJson.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public int Fibonacci(int n)
        {
            //restrictions 1 <= N <= 100
            if (n < 1 || n > 100)
            {
                return -1;
            }

            return Mth.CalculateFibonacci(n);
        }

        [HttpPost]
        public string XmlToJson(string xmlInput)
        {
            return WebUtils.XmlToJson(xmlInput);
        }
    }
}
