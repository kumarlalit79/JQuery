using JQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQuery.Controllers
{
    public class BindModelController : Controller
    {
        // GET: BindModel
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CalculateMethod(int num1 , int num2 , string name) // textbox mai se to 2 hi value ham le rahe hai, isliye yaha sirf do argument liye.yaha pe ek string value bhi bhej re dekho jq mai kese string se value get krte hai.
        {
            BindModel bindModel = new BindModel();

            bindModel.Add = num1 + num2;
            bindModel.Sub = num1 - num2;
            bindModel.Mul = num1 * num2;
            bindModel.Division = num1 / num2;

            return Json(bindModel);
        }
    }
}