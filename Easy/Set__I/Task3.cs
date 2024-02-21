using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_I
{
    public class Task3
    {
        public string ReverseString(string data)
        {
            string result="";  // initiales empty string to store the new string
            for(int i = data.Length-1; i >=0; i--)  // iterate over the string from the end of the Input string
            {

                result += data[i];      // append each character to a new string "Result"
            }
            return result;    //return value
        }
    }
}
