using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JQuery.ViewModel
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainCategory { get; set; }
        public DateTime CreationDate { get; set; }
    }
}