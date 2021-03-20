using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HitCounter : BaseEntity
    {
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public string ProName { get; set; }
    }
}
