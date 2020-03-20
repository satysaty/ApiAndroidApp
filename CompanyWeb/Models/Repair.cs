using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyWeb.Models
{
    public class Repair
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int CityId { get; set; }

        public string Phone { get; set; }

        public string Name { get; set; }

        public DateTime? SelectDate { get; set; }

        public Work Work { get; set; }

        public int? MasterId { get; set; }

        public string CommentUser { get; set; }

        public string CommentMaster { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public ICollection<Option> Options { get; set; }

        public Repair()
        {
            Options = new List<Option>();
        }
    }
}