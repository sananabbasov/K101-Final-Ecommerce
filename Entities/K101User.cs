using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class K101User:IdentityUser
    {
        public string FullName { get; set; }
        public string Adress { get; set; }
        public DateTime Birthday { get; set; }
        public string Image { get; set; }
    }
}
