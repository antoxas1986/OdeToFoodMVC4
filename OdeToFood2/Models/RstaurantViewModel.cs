using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood2.Models
{
    public class RstaurantViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int NumberOfReviews { get; set; }

    }
}