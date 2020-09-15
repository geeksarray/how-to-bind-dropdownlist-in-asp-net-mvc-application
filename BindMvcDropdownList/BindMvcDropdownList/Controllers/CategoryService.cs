using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc; 
using BindMvcDropdownList.Models;

namespace BindMvcDropdownList.Controllers
{
    public static class CategoryService
    {
        public static CategoryModel GetAllCategories()
        {
            CategoryModel categories = new CategoryModel();

            string query = string.Format("SELECT [CategoryID], [CategoryName] FROM [Categories]");

            using (SqlConnection con =
                    new SqlConnection("Data Source=AADITYA-PC;Initial Catalog=Northwind;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    categories.lstCategory = new List<SelectListItem>();  

                    while (reader.Read())
                    {
                        categories.lstCategory.Add(new SelectListItem { Text = reader.GetString(1), Value = reader.GetInt32(0).ToString() });                        
                    }
                }
            }

            if(categories.lstCategory.Count > 0 )
                categories.selected = 1; 

            return categories;            
        }        
    }
}