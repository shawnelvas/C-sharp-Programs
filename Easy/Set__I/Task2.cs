using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_I
{
    public class Task2 :BaseCalculator
    {
        
        public int CalculateAgeInSeconds(int ageInYears)
        {
       

            if (ageInYears > 0) // if age entered is positive ,do the following conversion
            {
               return ageInYears * DaysinYear * NoOfHours * NoOfMinutes * NoOfSeconds;
            }

            else  // if age entered is a negative number throw exception
            {
                throw new ArgumentException("ageInYears", "Age cannot be negative.");
            }
        }
    }
}
