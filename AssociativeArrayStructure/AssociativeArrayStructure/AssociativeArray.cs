using System;
using System.Collections.Generic;
using System.Text;

namespace AssociativeArrayStructure
{
    class AssociativeArray
    {
        public class Kvp
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public Kvp(string key, string value)
            {
                Key = key;
                Value = value;
            }
        }
        public Kvp[] AArray { get; set; }
        public int CapacityFilled { get; set; }

        public AssociativeArray(int startSize)
        {
            AArray = new Kvp[startSize];
            CapacityFilled = 0;
        }

        public void Reallocate()
        {
            AssociativeArray temp = new AssociativeArray(AArray.Length * 2);
            for (int i = 0; i < AArray.Length; i++)
            {
                
            }
        }

        public void Add(string key, string value)
        {
            var keyHashIndex = key.GetHashCode() % AArray.Length;
            if (AArray[keyHashIndex] == null)
            {
                AArray[keyHashIndex] = new Kvp(key, value);
                CapacityFilled++;
            }
            else
            {
                while (AArray[keyHashIndex] != null || keyHashIndex != AArray.Length)
                {
                    keyHashIndex++;
                }
                if (keyHashIndex >= AArray.Length)
                {
                    Reallocate();
                    Add(key, value);
                }
                else if (AArray[keyHashIndex] == null)
                {
                    AArray[keyHashIndex] = new Kvp(key, value);
                    CapacityFilled++;
                }
            }
        }
    }
}
