using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockoutJS_test.Controllers
{
    public class APIController : ApiController
    {
        public string Get()
        {
            return "Hi from web api controller";
        }
    }
}
