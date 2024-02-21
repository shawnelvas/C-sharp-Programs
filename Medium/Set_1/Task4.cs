using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Medium.Set_I
{
    public class Task4
    {
        public int[] SortArray(int[] arr)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] > 2)
                {
                    throw new ArgumentException();

                }
              

            }

            int count0 = 0, count1 = 0, count2 = 0;

            // Count occurrences of 0s, 1s, and 2s
            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 0:
                        count0++;
                        break;
                    case 1:
                        count1++;
                        break;
                    case 2:
                        count2++;
                        break;
                }
            }

            // Fill the array with 0s, 1s, and 2s in order
            int index = 0;
            for (int i = 0; i < count0; i++)
            {
                arr[index++] = 0;
            }
            for (int i = 0; i < count1; i++)
            {
                arr[index++] = 1;
            }
            for (int i = 0; i < count2; i++)
            {
                arr[index++] = 2;
            }


            return arr;

        }
    }
}
