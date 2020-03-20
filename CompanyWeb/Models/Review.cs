using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyWeb.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RepairId { get; set; }

        public int MasterId { get; set; }

        public string Text { get; set; }

        public int Rating { get; set; }
    }
}