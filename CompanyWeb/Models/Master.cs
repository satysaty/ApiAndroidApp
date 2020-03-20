using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace CompanyWeb.Models
{
    public class Master
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public string Name { get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

        public int Rating { get; set; }
        [IgnoreDataMember]
        public ICollection<Work> Works { get; set; }

        public int? WorksDone { get; set; }

        public Master()
        {
            Works = new List<Work>();
        }
    }
}