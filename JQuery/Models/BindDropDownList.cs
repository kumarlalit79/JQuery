using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JQuery.Models
{
    public class BindDropDownList
    {
        private List<CountryInfo> countries = new List<CountryInfo>();
        public List<CountryInfo> Countries
        {
            get { return countries; }
            set { countries = value; }
        }

        private List<StateInfo> states = new List<StateInfo>();
        public List<StateInfo> States
        {
            get { return states; }
            set { states = value; }
        }

        private List<CityInfo> cities = new List<CityInfo>();
        public List<CityInfo> Cities
        {
            get { return cities; }
            set { cities = value; }
        }

        //public List<CityInfo> Cities { get; set; }
    }
    public class CountryInfo
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }

    public class StateInfo
    {
        public int StateId { get; set; }

        public int CountryId { get; set; }
        public string StateName { get; set; }
    }

    public class CityInfo
    {
        public int CityId { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
    }
}