using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JQuery.ViewModel
{
    public class CascadinVM
    {
        public int stream_id { get; set; }
        public string stream_name { get; set; }
        public int course_id { get; set; }
        
        public string course_name { get; set; }
        public int specialization_id { get; set; }
        
        public string specialization_name { get; set; }
    }
}