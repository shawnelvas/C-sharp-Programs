using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_II
{
    public class Task6
    {
        
     public string RightTraingle(int rows)
        {
            string RightTrianglepattern = "";

            if (rows > 0)
            {
                for (int i = 1; i <= rows; i++)
                {
                    // Print spaces for left alignment
                    for (int j = rows - i; j > 0; j--)
                    {
                        RightTrianglepattern += " ";
                    }

                    // Print numbers in increasing order
                    for (int k = 1; k <= i; k++)
                    {
                        RightTrianglepattern += i;

                    }


                    RightTrianglepattern += "\n";
                }


                return RightTrianglepattern;
            }

            else
            {
                throw new ArgumentException("Invalid Argument");
            }
        }

    }
}
