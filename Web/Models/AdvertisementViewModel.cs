using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class AdvertisementViewModel
    {
        public List<Advertisement> Advertisements { get; set; }
        public Advertisement Advertisement { get; set; }
    }
}
