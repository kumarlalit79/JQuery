using JQuery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQuery.Controllers
{
    public class CRUD_JQ_ModalController : Controller
    {
        // GET: CRUD_JQ_Modal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllRecord()
        {
            using (JQueryEntities db = new JQueryEntities())
            {
                var data = db.Category_JQ.ToList();
                return Json(new { data } , JsonRequestBehavior.AllowGet); // yaha se data mughe json mai mil raha hai, ab ise jq ki help se page pe bind krunga.
            }
        }

        [HttpPost]
        public ActionResult AddUpdateCategory(Category_JQ c)
        {
            using (JQueryEntities db = new JQueryEntities())
            {
                // agr koi id nahi pass ho rahi to add krdo
                if(c.Id == 0)
                {
                    var addcat = db.Category_JQ.Add(c);
                    db.SaveChanges();
                    return Json(new { addcat }, JsonRequestBehavior.AllowGet);
                }

                // agr koi id pass ho rahi hai wo update krdo
                else
                {
                    var updatecat = db.Category_JQ.FirstOrDefault(x => x.Id == c.Id);
                    if(updatecat != null)
                    {
                        updatecat.Name = c.Name;
                        updatecat.MainCategory = c.MainCategory;
                        updatecat.CreationDate = c.CreationDate;

                    }
                    db.Entry(updatecat).State = EntityState.Modified;
                    db.SaveChanges();
                    return Json(new { updatecat }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public ActionResult GetCategoryDetails(int id)
        {
            using (JQueryEntities db = new JQueryEntities())
            {
                var data = db.Category_JQ.FirstOrDefault(m => m.Id == id);
                return Json(new { data } , JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult DeleteCategory(int id)
        {
            using (JQueryEntities db = new JQueryEntities())
            {
                var data = db.Category_JQ.FirstOrDefault(m => m.Id == id);
                if (data != null)
                {
                    db.Entry(data).State = EntityState.Deleted;
                    db.SaveChanges();
                    return Json(new { success = true });
                }
                return Json(new { success = false });
            }
        }

    }
}