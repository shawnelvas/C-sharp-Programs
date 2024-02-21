using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Medium.Set_I
{
    public class Task2
    {
        public int FindMissingNumber(int[] arr, int size)
        {
            // Calculate the sum of first n natural numbers
            int total = size * (size + 1) / 2;
            // Subtract the sum of the array elements from the total
            for (int i = 0; i < size - 1; i++)
            {
                total -= arr[i];
            }
            // The remaining value is the missing number
            return total;
        }
    }
}
 