using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_II
{
    public class Task8
    {
        public string Diamond(int rows)
        {

            string Diamondpattern = "";

            if (rows > 0)
            {
                // Upper half of the diamond
                for (int i = 1; i <= rows; i++)
                {
                    // Print spaces for alignment
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Diamondpattern += " ";
                    }

                    // Print stars in increasing order
                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Diamondpattern += "*";
                    }

                    Diamondpattern += "\n";
                }

                // Lower half of the diamond (excluding the middle row)
                for (int i = rows - 1; i >= 1; i--)
                {
                    // Print spaces for alignment
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Diamondpattern += " ";
                    }

                    // Print stars in decreasing order
                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Diamondpattern += "*";
                    }

                    Diamondpattern += "\n";
                }

                return Diamondpattern;
            }

            else
            {
                throw new ArgumentException();
            }
        }


     }
}

