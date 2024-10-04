using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI_Empty.Controllers
{
    // First class demo api calling 
    public class GetDataController : ApiController
    {
        string[] data = { "C#", "java", "Php", "Go" };
        public string[] GetData()
        {
            return data;
        }
        public string GetDataByID(int id)
        {
            return data[id];    
        }
    }
}
