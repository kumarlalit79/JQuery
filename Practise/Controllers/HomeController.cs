using Practise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Operation(int num1 , int num2)
        {
            AMSD_Operation obj = new AMSD_Operation();
            obj.Add = num1 + num2;
            obj.Sub = num1 - num2;
            obj.Mul = num1 * num2;
            obj.Div = num1 % num2;

            return Json(obj);
        }
    }
}