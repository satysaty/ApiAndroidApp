using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CompanyWeb.Models
{
    public class Option
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Price { get; set; }
        [IgnoreDataMember]
        public ICollection<WorkOption> WorkOptions { get; set; }
        [IgnoreDataMember]
        public ICollection<Repair> Repairs { get; set; }

        public Option()
        {
            Repairs = new List<Repair>();

            WorkOptions = new List<WorkOption>();
        }
    }
}