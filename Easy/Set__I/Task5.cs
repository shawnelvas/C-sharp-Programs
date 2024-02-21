using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_I
{
    public class Task5 :BaseCalculator
    {
        
        public int ConvertHoursToSeconds(int hours)
        {
            if (hours >= 0)
                return hours * NoOfMinutes * NoOfSeconds;


            else
                throw new ArgumentException("No of hours entered cannot be negative.", nameof(hours));
        
        
        
        }

    }
}
