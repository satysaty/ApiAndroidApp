using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CompanyWeb.Models
{
    public class WorkOption
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Last { get; set; }

        public ICollection<Work> Works { get; set; }

        public ICollection<Option> Options { get; set; }

        public WorkOption()
        {
            Options = new List<Option>();

            Works = new List<Work>();
        }
    }
}