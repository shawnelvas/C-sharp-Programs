using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_III
{
    public class Task1
    {

        public string IsPalindrome(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Invalid Argument: Number cannot be negative");
            }

            int reversedNum = 0, remainder;
            int originalNum = num;

            while (num > 0)
            {
                remainder = num % 10;
                reversedNum = reversedNum * 10 + remainder;
                num /= 10;
            }

            return originalNum == reversedNum ? "Palindrome number" : "Not palindrome number";
        }
    }
}



