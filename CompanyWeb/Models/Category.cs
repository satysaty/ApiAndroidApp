using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyWeb.Models
{
    public class Category
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public int MainCategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }

        public ICollection<Work> Works { get; set; }

        public Category()
        {
            Works = new List<Work>();
        }
    } 
}