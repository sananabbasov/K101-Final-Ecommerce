using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Blog : BaseEntity
    {
        public string PostName { get; set; }
        public string PostUrl { get; set; }
        public string PhotoUrl { get; set; }
        public int Hit { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public DateTime PostDate { get; set; }
        public int MyProperty { get; set; }
        public string Description { get; set; }
    }
}
