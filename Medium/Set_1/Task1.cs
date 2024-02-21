using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Medium.Set_I
{
    public class Task1
    {
        public int FindWaysToClimbTop(int step)
        {
            if (step < 0)
            {
                throw new ArgumentException();
            }

            else
            {
                // Create an array to store the results of the subproblems
                int[] dp = new int[step + 1];
                // Base cases: if n is 0 or 1, there is only one way to climb
                dp[0] = 1;
                dp[1] = 1;
                // Loop from 2 to n and fill the array with the sum of the previous two values
                for (int i = 2; i <= step; i++)
                {
                    dp[i] = dp[i - 1] + dp[i - 2];
                }
                // Return the last element of the array, which is the answer
                return dp[step];
            }
        }
    }

    }

