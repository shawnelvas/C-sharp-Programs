using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_II
{
    public class Task2
    {
     public int[] SwapElements(int[] lists)

        {
            int temp = lists[0]; // Storing the value of the first element in a temporary variable
            lists[0] = lists[lists.Length - 1]; // Assigning the value of the last element to the first element
            lists[lists.Length - 1] = temp; // Assigning the value of the temporary variable to the last element

            return lists; // Returning the modified array
        }
    }
}
