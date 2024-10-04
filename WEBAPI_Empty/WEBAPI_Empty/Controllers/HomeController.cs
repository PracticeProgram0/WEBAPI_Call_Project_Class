using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WEBAPI_Empty.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {  
            // User ko View show karany ka code   data show

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44337/api/DataAccess");
            var responce = client.GetAsync("DataAccess");
            responce.Wait();
            var data= responce.Result;  
            if( data.IsSuccessStatusCode)
            {
                var demodata=data.Content.ReadAsAsync<List<ImageUpload>>();
                demodata.Wait();
                List<ImageUpload> list=demodata.Result;
                return View(list);
            }
            return View();
        }
    }
}