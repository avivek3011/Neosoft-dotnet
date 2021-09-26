using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Web.Models;

namespace Web.Controllers
{
    public class Pet1Controller : Controller
    {
        // GET: Pet1
        //1. Install-Package Microsoft.AspNet.WebApi.Client        
        public ActionResult Index()
        {
            List<CatApiModel> cats = null;
            //2. create instance of http client
            using (HttpClient client=new HttpClient())
            {
                //3. create the URL that needs to used to access the resource
                client.BaseAddress = new Uri("https://localhost:44391/api/Pet");
                var response=client.GetAsync("Pet");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var data=result.Content.ReadAsAsync<IEnumerable<Models.CatApiModel>>();
                    data.Wait();
                    cats = data.Result as List<CatApiModel>;
                }
            }
            return View(cats);
        }
    }
}