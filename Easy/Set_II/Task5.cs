using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_II
{
    public class Task5
    {
        public string LeftTriangle(int rows)
        {
            if ( rows > 0)
            {
                string LeftTrianglepattern = "";
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        LeftTrianglepattern += i + "";
                    }

                    LeftTrianglepattern += "\n"; // Add a newline for the next row
                }

                return LeftTrianglepattern;
            }
            else
            {
                throw new ArgumentException("Invalid input");
            }
        }
    }
}
