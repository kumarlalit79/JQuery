using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQuery.Controllers
{
    public class GetValInTxtBController : Controller
    {
        // GET: GetValInTxtB
        public ActionResult Index()
        {
            return View();
        }

        //Passing Form Data to Controller Using jQuery
        [HttpPost]
        public int Addition(int num1 , int num2)
        {
            return num1 + num2;
        }

        [HttpPost]
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}