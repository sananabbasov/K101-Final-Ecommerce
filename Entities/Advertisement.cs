using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Advertisement : BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string PhotoURL { get; set; }
        public int Click { get; set; }
        public DateTime EndTime { get; set; }
    }
}
