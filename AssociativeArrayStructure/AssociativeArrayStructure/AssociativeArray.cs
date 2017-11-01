using System;
using System.Collections.Generic;
using System.Text;

namespace AssociativeArrayStructure
{
    class AssociativeArray
    {
        public Object[] Kvp { get; set; }
        public int CapacityFilled { get; set; }

        public AssociativeArray(int startSize)
        {
            Kvp = new Object[startSize];
            CapacityFilled = 0;
        }

        public void Add(string key, string value)
        {
            var keyHashIndex = key.GetHashCode() % Kvp.Length;
            if (Kvp[keyHashIndex] == null)
            {
                Kvp[keyHashIndex] = new { key = value };
                CapacityFilled++;
            }
            else
            {
                while (Kvp[keyHashIndex] != null || keyHashIndex != Kvp.Length)
                {
                    keyHashIndex++;
                }
                if (keyHashIndex >= Kvp.Length)
                {
                    Reallocate();
                    Add(key, value);
                }
                else if (Kvp[keyHashIndex] == null)
                {
                    Kvp[keyHashIndex] = new { key = value };
                    CapacityFilled++;
                }
            }
        }
    }
}
