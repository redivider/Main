using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Entity
{
    public class EntityValue
    {
        public string Name{ get; set; }

        public int EntityId { get; set; }
        public int ItemId { get; set; }
        public string Text{ get; set; }
        public DateTime Time{ get; set; }
        public decimal Number{ get; set; }

    }
}
