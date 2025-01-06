using Practise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practise.Controllers
{
    public class CascadngController : Controller
    {
        // GET: Cascadng
        public ActionResult Index()
        {
            List<Country> CountryList = new List<Country>();
            List<State> StateList = new List<State>();
            List<City> CityList = new List<City>();
            using (CascadingDDLEntities db = new CascadingDDLEntities())
            {
                var countryData = db.Countries.ToList();
                foreach (var item in countryData)
                {
                    CountryList.Add(new Country
                    {
                        CountryId = int.Parse(item.CountryId.ToString()),
                        CountryName = item.CountryName.ToString(),
                    });
                }

                ViewBag.CountryList = new SelectList(countryData, "CountryId", "CountryName");

                var stateData = db.States.Include("Country").ToList();
                foreach (var item in stateData)
                {
                    StateList.Add(new State
                    {
                        StateId = int.Parse(item.StateId.ToString()), 
                        StateName = item.StateName.ToString(),
                    });
                }

                ViewBag.StateList = new SelectList(stateData, "StateId", "StateName");


                var cityData = db.Cities.Include("State").ToList();
                foreach (var item in cityData)
                {
                    CityList.Add(new City
                    {
                        CityId = int.Parse(item.CityId.ToString()),
                        CityName = item.CityName.ToString(),
                    });
                }

                ViewBag.CityList = new SelectList(cityData, "CityId", "CityName");
            }
            return View();
        }

        public JsonResult State(int countryId)
        {
            using (CascadingDDLEntities db = new CascadingDDLEntities())
            {

                var stateData = db.States.Where(e => e.CountryId == countryId).ToList();
                return Json(new {data= stateData }, JsonRequestBehavior.AllowGet);
            }
            
        }
    }
}