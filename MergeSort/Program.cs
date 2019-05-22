using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<int> l = new List<int>();
            for (int i = 0; i < 100; i++)
                l.Add(r.Next());
            Quick q = new Quick();
            List<int> res = q.Sort(l);
        }
    }
}
