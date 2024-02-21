using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_III
{
    public  class Task3
    {

        public  bool IsPalindromeString(string text)
        {
            // Preprocess for clarity and case-insensitivity
            string processedString = text.ToLower().Replace(" ", "");
            // string processedString = Regex.Replace(str.ToLower(), @"[^a-zA-Z0-9]", "");  // Remove non-alphanumeric characters

            // Two-pointer approach for efficient palindrome check
            int left = 0, right = processedString.Length - 1;

            while (left < right)
            {
                if (processedString[left] != processedString[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
