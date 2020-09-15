using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BindMvcDropdownList.Models
{
    public class CategoryModel
    {
        public List<SelectListItem> lstCategory { get; set; }
        public Int16 selected { get; set; }
    }
}