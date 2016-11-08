using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using General.Entity;
using System.Collections.Generic;

namespace General.Test.Entity
{
    [TestClass]
    public class EntityTests
    {
        [TestMethod]
        public void Serialize()
        {
            int eId = 22;
            string eType = "Dog";
            EntityItem item = TestObjectFactory.BuildEItem(eId, eType);

            EntityValue values = TestObjectFactory.BuildEValues(eId, "Name", "Fezzik");
        }
    }
}
