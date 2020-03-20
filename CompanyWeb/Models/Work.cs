using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace CompanyWeb.Models
{
    public class Work
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public string Piece { get; set; }

        public ICollection<WorkOption> WorkOptions { get; set; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<Master> Masters { get; set; }

        public Work()
        {
            Categories = new List<Category>();
            WorkOptions = new List<WorkOption>();
            Masters = new List<Master>();
        }
    }
}