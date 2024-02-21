using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_I
{
    public class Task4 :BaseCalculator
    {
    
            public int[] SumTwoNumbers(int[] numbers, int target)
            {
                int[] resultArray = new int[2];

                int isValidate = ValidateArray(numbers, target);

                if (isValidate == 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        for (int j = i + 1; j < numbers.Length; j++)
                            if (numbers[i] + numbers[j] == target)
                            {
                                resultArray[0] = i;
                                resultArray[1] = j;
                            }
                    }

                    return resultArray;
                }
            }

            public static int ValidateArray(int[] arr, int tar)
            {
                int count = 0;
                int arrayLength = arr.Length;
                if (arrayLength >= MIN_ARRAY_LENGTH && arrayLength <= MAX_ARRAY_LENGTH && tar >= MIN_TARGET_RANGE && tar <= MAX_TARGET_RANGE)
                {
                    for (int i = 0; i < arrayLength; i++)
                    {
                        if (arr[i] >= MIN_ARRAY_ELEMENT_VALUE && arr[i] <= MAX_ARRAY_ELEMENT_VALUE)
                            count++;
                    }

                }
                if (count == arr.Length)
                    return 1;

                else
                    return 0;
            }

        }
    }





