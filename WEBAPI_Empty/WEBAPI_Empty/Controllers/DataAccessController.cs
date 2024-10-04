using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI_Empty.Controllers
{
    // Second Class Database Access 
    public class DataAccessController : ApiController
    {
        // DataBase say  all data access  bulk amount code 

        [System.Web.Http.HttpGet] // NameSpace h
        public IHttpActionResult Index()
        {
            using (var context=new VIVEKEntities())//VIVEKE Database ka name h
            {
                var data =context.ImageUploads.ToList();// ImageUploade Table Name h 
                return Ok(data);

            }
        }

    }
}
