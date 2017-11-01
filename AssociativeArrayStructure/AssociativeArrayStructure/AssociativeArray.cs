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
            foreach (var item in AArray)
            {
                if (item != null)
                {
                    temp.Add(item.Key, item.Value); 
                }
            }
            AArray = temp.AArray;
        }

        public void Add(string key, string value)
        {
            var keyHashIndex = Math.Abs(key.GetHashCode() % AArray.Length);
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
            if (CapacityFilled >= AArray.Length / 2)
            {
                Reallocate();
            }
        }

        public Kvp Remove(string key)
        {
            var location = Math.Abs(key.GetHashCode() % AArray.Length);
            while (AArray[location].Key != key && location < AArray.Length)
            {
                location++;
            }
            if (AArray[location].Key != key)
            {
                return new Kvp("Not", "Found");
            }
            
        }
    }
}
