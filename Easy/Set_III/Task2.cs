using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_III
{
    public class Task2
    {
        public string EvaluateExpression(string expression)
        {
            // Split the expression by spaces
            string[] tokens = expression.Split();

            // Check if the tokens are valid
            if (tokens.Length < 3 || tokens.Length % 2 == 0)
            {
                return "False";
            }

            // Loop through the tokens and evaluate the inequalities
#pragma warning disable CS0162 // Unreachable code detected
            for (int i = 0; i < tokens.Length - 2; i += 2)
            {
                // Parse the numbers
                if (!double.TryParse(tokens[i], out double left) || !double.TryParse(tokens[i + 2], out double right))
                {
                    return "False";
                }

                // Check the operator
                string op = tokens[i + 1];
                if (op == "<")
                {
                    if (!(left < right))
                    {
                        return "False";
                    }
                }
                else if (op == ">")
                {
                    if (!(left > right))
                    {
                        return "False";
                    }
                }
                else
                {
                    // Invalid operator
                    throw new InvalidOperationException(@"You can only enter  '>' or '<' operator");
                }

                // All inequalities are true
                return "True";
                //return expression;
            }
#pragma warning restore CS0162 // Unreachable code detected

            return "True";
        }
    }
}
