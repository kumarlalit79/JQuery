using JQuery.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQuery.Controllers
{
    public class CascadingDDLController : Controller
    {
        // GET: CascadingDDL
        public ActionResult Index()
        {
            using (JQueryEntities db = new JQueryEntities())
            {

                // Streams_tbl 
                List<Streams_tbl> streamsTbl = new List<Streams_tbl>();
                var streamsData = db.Streams_tbl.ToList();
                foreach (var items in streamsData)
                {
                    streamsTbl.Add(new Streams_tbl
                    {
                        stream_id = int.Parse((items.stream_id).ToString()),
                        stream_name = items.stream_name.ToString(),
                    });
                }

                ViewBag.streams = new SelectList(streamsTbl, "stream_id", "stream_name");

                // course table
                List<Courses_tbl> coursesTbl = new List<Courses_tbl>();
                var courseData = db.Courses_tbl.ToList();
                foreach (var item in courseData)
                {
                    coursesTbl.Add(new Courses_tbl
                    {
                        course_id = int.Parse((item.course_id).ToString()),
                        course_name = item.course_name.ToString(),
                    });
                }
                ViewBag.course = new SelectList(coursesTbl, "course_id", "course_name");

                // Specializations_tbl
                List<Specializations_tbl> specializationsTbl = new List<Specializations_tbl>();
                var specializationsData = db.Specializations_tbl.ToList();
                foreach (var item in specializationsData)
                {
                    specializationsTbl.Add(new Specializations_tbl
                    {
                        specialization_id = int.Parse((item.specialization_id).ToString()),
                        specialization_name = item.specialization_name.ToString(),
                    });
                }

                ViewBag.specialization = new SelectList(specializationsTbl, "specialization_id", "specialization_name");


                return View();
            }
        }


        [HttpPost]
        public ActionResult CourseDropdown(int streamId)
        {
            using (JQueryEntities db = new JQueryEntities())
            {
                var course = db.Courses_tbl.Where(x => x.stream_id == streamId).ToList();
                return Json(new {course} , JsonRequestBehavior.AllowGet);
            }
        }
    }
}