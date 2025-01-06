using JQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQuery.Controllers
{
    public class BindDropDownListController : Controller
    {
        // GET: BindDropDownList
        public ActionResult Index()
        {
            BindDropDownList model = new BindDropDownList();
            model.Countries.Add(new CountryInfo { CountryId = 1, CountryName = "India" });
            model.Countries.Add(new CountryInfo { CountryId = 2, CountryName = "America" });
            model.Countries.Add(new CountryInfo { CountryId = 3, CountryName = "Newzeland" });
            model.Countries.Add(new CountryInfo { CountryId = 4, CountryName = "Australia" });
            model.Countries.Add(new CountryInfo { CountryId = 5, CountryName = "New York" });
            model.Countries.Add(new CountryInfo { CountryId = 6, CountryName = "Paris" });
            model.Countries.Add(new CountryInfo { CountryId = 7, CountryName = "England" });
            model.Countries.Add(new CountryInfo { CountryId = 8, CountryName = "America" });
            model.Countries.Add(new CountryInfo { CountryId = 9, CountryName = "Japan" });

            return View(model);
        }

        [HttpPost]
        public ActionResult StateData(int countryid)
        {
            List<StateInfo> StateList = new List<StateInfo>()
            {
                new StateInfo(){ CountryId = 1, StateId = 1 , StateName = "Uttrakhand" },
                new StateInfo(){ CountryId = 1, StateId = 2 , StateName = "Pune" },
                new StateInfo(){ CountryId = 2, StateId = 3 , StateName = "TestAmerica1" },
                new StateInfo(){ CountryId = 2, StateId = 4 , StateName = "TestAmerica1" },
                new StateInfo(){ CountryId = 3, StateId = 5 , StateName = "TestNewzeland1" },
                new StateInfo(){ CountryId = 3, StateId = 6 , StateName = "TestNewzeland2" },
                new StateInfo(){ CountryId = 4, StateId = 7 , StateName = "TestAustralia1" },
                new StateInfo(){ CountryId = 4, StateId = 8 , StateName = "TestAustralia2" },
                new StateInfo(){ CountryId = 5, StateId = 9 , StateName = "TestNew York" },
                new StateInfo(){ CountryId = 5, StateId = 10 , StateName = "TestNew York1" },
                new StateInfo(){ CountryId = 5, StateId = 11 , StateName = "TestNew York2" },
                new StateInfo(){ CountryId = 6, StateId = 12 , StateName = "Paris" },
                new StateInfo(){ CountryId = 7, StateId = 13 , StateName = "England" },
                new StateInfo(){ CountryId = 8, StateId = 14 , StateName = "America" },
                new StateInfo(){ CountryId = 9, StateId = 15 , StateName = "Japan" },
                new StateInfo(){ CountryId = 10, StateId = 16 , StateName = "Japan" }
            };

            BindDropDownList model = new BindDropDownList();
            model.States = StateList.Where(s => s.CountryId == countryid).ToList();
            return Json(model);
        }

        [HttpPost]
        public ActionResult CityData(int stateid)
        {
            List<CityInfo> CityList = new List<CityInfo>()
            {
                new CityInfo(){StateId = 1, CityId = 1 ,  CityName = "ramnagar" },
                new CityInfo(){ StateId = 2, CityId = 2 , CityName= "puneRmangar" },
                new CityInfo(){ StateId = 3, CityId = 3 , CityName= "CityAmerica1" },
                new CityInfo(){ StateId = 4, CityId = 4 , CityName= "cityAmerica1" },
                new CityInfo(){ StateId = 5, CityId = 5 , CityName= "cityNewzeland1" },
                new CityInfo(){ StateId = 6, CityId = 6 , CityName= "cityNewzeland2" },
                new CityInfo(){ StateId = 7, CityId = 7 , CityName= "cityAustralia1" },
                new CityInfo(){ StateId = 8, CityId = 8 , CityName= "cityAustralia2" },
                new CityInfo(){ StateId = 9, CityId = 9 , CityName= "cityNew York" },
                new CityInfo(){ StateId = 10, CityId = 10 ,CityName = "cityNew York1" },
                new CityInfo(){ StateId = 11, CityId = 11 ,CityName = "cityNew York2" },
                new CityInfo(){ StateId = 12, CityId = 12 ,CityName = "cityParis" },
                new CityInfo(){ StateId = 13, CityId = 13 ,CityName = "cityEngland" },
                new CityInfo(){ StateId = 14, CityId = 14 ,CityName = "cityAmerica" },
                new CityInfo(){ StateId = 15, CityId = 15 ,CityName = "cityJapan" },
                new CityInfo(){ StateId = 16, CityId = 16 ,CityName = "cityJapan" }
            };

            BindDropDownList model = new BindDropDownList();
            model.Cities = CityList.Where(s => s.CityId == stateid).ToList();
            return Json(model);
        }
    }


}