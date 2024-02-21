using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_I
{
    public class Task6
    {

        public string FindNumber(int[] arrayOne, int[] arrayTwo, int number)
        {
            bool arr1 = false ; // flag for array 1 if element is found
            bool arr2 = false;  // flag for array 2 if element is found


            for (int i=0;i< arrayOne.Length; i ++)  // For loop to iterate over array 1
            {
                if (arrayOne[i] == number)     // checking if number exits in the array 1
                {
                     arr1 = true;               // set flag of array 1 to true if number is found
                }
            }

            for (int j = 0; j < arrayTwo.Length; j++)  // For loop to iterate over array 1
            {
                if (arrayTwo[j] == number)               // checking if number exits in the array 2
                {
                    arr2 = true;                         // set flag of array 2 to true if number is found
                }
            }
            if(arr1 == true && arr2 == true)    // if element is present in both arrays
            {
                return $"number {number} found in both arrays";   //print
            }
            else if(arr1 == true && arr2 == false)          // if element is present in  array1
            {
                 return $"number {number} found in array 1";  //print
                
            }

            else if (arr1 == false && arr2 == true)      // if element is present in array2
            {
                return  $"number {number} found in array 2"; //print
               
            }

            else                                           // if element is not present in both arrays
            {
                return $"number {number} not found in both arrays";  //print
              }
            
        }
         
    }
}
