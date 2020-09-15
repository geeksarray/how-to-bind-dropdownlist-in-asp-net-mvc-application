using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BindMvcDropdownList.Models;

namespace BindMvcDropdownList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BindWithViewBag()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Select Category", Value = "0", Selected = true });

            items.Add(new SelectListItem { Text = "Beverages", Value = "1" });

            items.Add(new SelectListItem { Text = "Condiments", Value = "2" });

            items.Add(new SelectListItem { Text = "Confections", Value = "3" });

            items.Add(new SelectListItem { Text = "Dairy Products", Value = "4" });

            items.Add(new SelectListItem { Text = "Grains/Cereals", Value = "5" });

            items.Add(new SelectListItem { Text = "Meat/Poultry", Value = "6" });

            items.Add(new SelectListItem { Text = "Produce", Value = "7" });

            items.Add(new SelectListItem { Text = "Seafood", Value = "8" });

            ViewBag.CategoryType = items;

            return View();
        }

        public ActionResult BindWithModel()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Select Category", Value = "0", Selected = true });
            items.Add(new SelectListItem { Text = "Beverages", Value = "1" });
            items.Add(new SelectListItem { Text = "Condiments", Value = "2" });
            items.Add(new SelectListItem { Text = "Confections", Value = "3" });
            items.Add(new SelectListItem { Text = "Dairy Products", Value = "4" });
            items.Add(new SelectListItem { Text = "Grains/Cereals", Value = "5" });
            items.Add(new SelectListItem { Text = "Meat/Poultry", Value = "6" });
            items.Add(new SelectListItem { Text = "Produce", Value = "7" });
            items.Add(new SelectListItem { Text = "Seafood", Value = "8" });

            var model = new CategoryModel()
            {
                lstCategory = items,
                selected = 1
            };

            return View(model);
        }

        public ActionResult BindWithDbValues()
        {
            CategoryModel categories = CategoryService.GetAllCategories();
            return View("BindWithModel", categories); 
        }

        

        public ActionResult StaticBind()
        {
            return View();
        }
    }
}