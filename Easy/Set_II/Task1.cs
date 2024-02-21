using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_II
{
    public class Task1
    {
        public int SumDictionary(Dictionary<string, int> items)
        {
            int sum = 0;    
            foreach (var item in items)
            {
                 sum += item.Value;
            }

            return sum;
        }


    }
}
