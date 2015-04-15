using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCall.Models
{
    public class Call
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}