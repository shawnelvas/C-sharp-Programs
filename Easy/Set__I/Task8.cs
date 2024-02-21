using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_I
{
    public class Task8
    {
       
            // To get each value of a smaller case alphabet
            // from the ascii value to begin  with value of a= 11,b=12 and so on
            // we introduce a base value  that has to be subtracted from each chracters ascci value//
            // Value of Base = 86 
        public int SentenceValue(string text) 
        {
            int totalValue = 0;
            int BaseValue = 86;
            int ascii_value = 0;
            int Value = 0;
            // converting string to lower case incase uppcase alphabets are entered//
            text = text.ToLower();

            // For loop to iterate over the  entire string//
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    ascii_value = Convert.ToByte(c); // converting each character to its ascii value
                    Value = ascii_value - BaseValue;  //  subtracting ascii value of each alphabet with the base value
                    totalValue += Value;  // append the new value of each alphabet to the total value.
                }

                else
                {
                    Value = 0;
                }
            }

            return totalValue;  // print the total value of the entire string


        }
    }
    }

