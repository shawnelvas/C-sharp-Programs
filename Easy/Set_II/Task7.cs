using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_II
{
    public class Task7
    {

        public string Pyramid(int rows)
        {

            if (rows > 0)
            {
                string Pyramidpattern = "";

                for (int i = 1; i <= rows; i++)
                {
                    // Print spaces for alignment
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Pyramidpattern += " ";
                    }

                    // Print stars in increasing order
                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Pyramidpattern += "*";
                    }

                    Pyramidpattern += "\n";
                }

                return Pyramidpattern;
            }

            else
            {
                throw new ArgumentException();
            }
        }
    }




 }
