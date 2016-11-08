using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General.Entity;

namespace General
{
    public static partial class TestObjectFactory
    {
        internal static EntityItem BuildEItem(int eId, string eType, int? parentId = null)
        {
            return new EntityItem
            {
                ItemId = eId,
                Name = eType,
                ParentId = parentId
            };
        }

        internal static EntityValue BuildEValues(int eId, string name, string value)
        {
            return new EntityValue
            {
                Name = name,
                EntityId = eId,
                Text = value
            };
        }
    }
}
