using System;
using System.Collections.Generic;
using System.Linq;

namespace CSort
{
    public class Quick
    {
        public int iterCount = 0;
        public List<T> Sort<T>(List<T> values)
             where T : IComparable
        {
            if (values.Count == 0)
            {
                return new List<T>();
            }
            T firstElement = values[0];

            var smallerElements = new List<T>();
            var largerElements = new List<T>();
            for (int i = 1; i < values.Count; i++)
            {
                iterCount++;
                var elem = values[i];
                if (elem.CompareTo(firstElement) < 0)
                {
                    smallerElements.Add(elem);
                }
                else
                {
                    largerElements.Add(elem);
                }
            }      
            var result = new List<T>();
            result.AddRange(Sort(smallerElements.ToList()));
            result.Add(firstElement);
            result.AddRange(Sort(largerElements.ToList()));
            return result;
        }
    }
}


