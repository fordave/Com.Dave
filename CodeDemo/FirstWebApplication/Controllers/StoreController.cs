using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApplication.Controllers
{
    public class StoreController : Controller
    {
        //// GET: Store
        //public ActionResult Index()
        //{
        //    return View();
        //} 
        // GET: Store
        public string Index()
        {
            return "hello";
        }

        // GET: Store
        public string Browse(string genre)
        {
            var message = HttpUtility.HtmlEncode($"store .browse ,genre= {genre}");
            return message;
        }
        // GET: Store/details/?
        public string Details(int id)
        {
            var message = HttpUtility.HtmlEncode($"store .details ,id= {id}");
            return message;
        }
    }
}