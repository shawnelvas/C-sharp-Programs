using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignments.Medium.Set_I

{

    public class Task3
    {
        public string[] NumbersInStrings(string[] arr)
        {
            string[] result = new string[arr.Length];

            int indexOfResultArray = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Any(Char.IsDigit))
                {
                    result[indexOfResultArray] = arr[i];
                    indexOfResultArray++;
                }

            }

            return result;

        }

    }

}