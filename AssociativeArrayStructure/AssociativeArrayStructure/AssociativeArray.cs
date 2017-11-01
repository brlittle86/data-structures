using System;
using System.Collections.Generic;
using System.Text;

namespace AssociativeArrayStructure
{
    class AssociativeArray
    {
        public Object[] Kvp { get; set; }
        public int CapacityFilled { get; set; }

        public AssociativeArray()
        {
            Kvp = new Object[20];
            CapacityFilled = 0;
        }
    }
}
