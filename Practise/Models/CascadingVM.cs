using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practise.Models
{
    public class CascadingVM
    {

        public List<Country> country { get; set; }
        public List<State> state { get; set; }
        public List<City> city { get; set; }
        
    }
}