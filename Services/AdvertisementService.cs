using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AdvertisementService
    {
        private EcommerceContext _context;
        public AdvertisementService(EcommerceContext context)
        {
            _context = context;
        }
        public List<Advertisement> GetAdvertisements()
        {
            return _context.Advertisementies.ToList();
        }
    }
}
