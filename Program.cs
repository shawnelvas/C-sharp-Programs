// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!")

using System;
using set_1 = Assignments.Easy.Set_I;
using set_2= Assignments.Easy.Set_II;
using set_3 = Assignments.Easy.Set_III;
using set_4 = Assignments.Easy.Set_IV;
using Assignments.Medium; 
using Assignments.Easy;
//using Task1 = Assignments.Easy.Set_I.Task1; // Import the Easy namespace

namespace Program
{
    class Program
    {
        public static void Main()
        {


            /*
                        //Various Classes OF Set 1
                      calculateAgeInDay();
                        calculateAgeInSeconds();
                        reverseString();
                        sumOfTwoNumbers();
                        howManySeconds();
                        numberInArray();
                        formatDate();
                        valueOfString();



                      //  Classes of task2
                         sumDictonary();
                        swapElements();
                        rectangle();
                        CalculatePersonAge();
                        leftTianglePattern();

                        rightTrianglePattern();

                        pyramidPattern();

                        diamondPattern();
            */

            //set 3 Classes
            //sPalindrome();
            //sPalindromeString();
            // evaluateExpression();

            //Medium Task 
            findWaysToClimbTop();
            findMissingNumber();
            //sortArray();
           // numberInTheString();

        }
        #region Easy;
        #region Easy_Set_1;

        public static void calculateAgeInDay()
        {
            set_1.Task1 t1 = new set_1.Task1();
            try
            {
                int age = -1;
                int result1 = t1.CalculateAgeInDays(age);
                Console.WriteLine($"The Age in Years is {age} and The age in days is {result1}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error :{ex.Message}");


            }


            try
            {
                int age = 0;
                int result1 = t1.CalculateAgeInDays(age);
                Console.WriteLine($"The age in Years is {age} and The Age in days is {result1}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error :{ex.Message}");


            }

            try
            {
                int age = 20;
                int result1 = t1.CalculateAgeInDays(age);
                Console.WriteLine($"The age in Years is {age} and The Age in days is {result1}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error :{ex.Message}");


            }
        }

        public static void calculateAgeInSeconds()
        {
            Assignments.Easy.Set_I.Task2 t1 = new Assignments.Easy.Set_I.Task2();

            try
            {
                int age = 23;
                int result1 = t1.CalculateAgeInSeconds(age);
                Console.WriteLine($"The age in Years is {age} and The Age in seconds is {result1}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error :{ex.Message}");
            }


            try
            {
                int age = 0;
                int result1 = t1.CalculateAgeInSeconds(age);
                Console.WriteLine($"The age in Years is {age} and The Age in seconds is {result1}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error :{ex.Message}");


            }

            try
            {
                int age = 20;
                int result1 = t1.CalculateAgeInSeconds(age);
                Console.WriteLine($"The age in Years is {age} and The Age in days is {result1}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error :{ex.Message}");


            }
        }

        public static void reverseString()
        {
            set_1.Task3 t3 = new set_1.Task3();
            String str = "hello";
            string Result = t3.ReverseString(str);
            Console.WriteLine($"The Input string is {str} and The Reverse of the String is {Result}");

            String str1 = "goa";
            string Result1 = t3.ReverseString(str1);
            Console.WriteLine($"The Input string is {str1} and The Reverse of the String is {Result1}");


            String str2 = "India";
            string Result2 = t3.ReverseString(str2);
            Console.WriteLine($"The Input string is {str2} and The Reverse of the String is {Result2}");
        }

        public static void sumOfTwoNumbers()
        {
            set_1.Task4 t1 = new set_1.Task4();
            int[] result = t1.SumTwoNumbers([2, 7, 11, 15], 9);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(result[i]);

            }

            int[] result1 = t1.SumTwoNumbers([3, 2, 4], 6);
            for (int i = 0; i < result1.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(result1[i]);
                // Console.Write(" ");
            }

            int[] result2 = t1.SumTwoNumbers([3, 3], 6);
            for (int i = 0; i < result2.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(result2[i]);
                // Console.Write(" ");
            }
        }


        public static void howManySeconds()
        {
            set_1.Task5 t5 = new set_1.Task5();

            int Hours = 2;
            int result = t5.ConvertHoursToSeconds(Hours);
            Console.WriteLine($"{Hours} hours has {result} seconds");


            int Hours1 = 24;
            int result1 = t5.ConvertHoursToSeconds(Hours1);
            Console.WriteLine($"{Hours1} hours has {result1} seconds");


            int Hours2 = 0;
            int result2 = t5.ConvertHoursToSeconds(Hours2);
            Console.WriteLine($"{Hours2} hours has {result2} seconds");
        }

        public static void numberInArray()
        {
            set_1.Task6 t6 = new set_1.Task6();
            int[] array_one = { 5, 8, 9, 10 };
            int[] array_two = { 5, 8, 9, 10, 12, 20, 40, 60, 70 };
            int number = 10;
            string result1 = t6.FindNumber(array_one, array_two, number);
            Console.WriteLine(result1);



            int[] array_3 = { 1, 5, 8, 9, 10 };
            int[] array_4 = { 5, 8, 9, 10, 12, 20, 40, 60, 70 };
            int number1 = 70;
            string result2 = t6.FindNumber(array_3, array_4, number1);
            Console.WriteLine(result2);


            int[] array_5 = { 1, 5, 8, 9, 10 };
            int[] array_6 = { 5, 8, 9, 10, 12, 20, 40, 60, 70 };
            int number2 = 1;
            string result3 = t6.FindNumber(array_5, array_6, number2);
            Console.WriteLine(result3);



        }

        public static void formatDate()
        {

            set_1.Task7 t7 = new set_1.Task7();
            string inputdate = "21-04-2024";
            string result = t7.FormatDate(inputdate);
            Console.WriteLine(result);


            string inputdate1 = "22-06-2024";
            string result1 = t7.FormatDate(inputdate1);
            Console.WriteLine(result1);

            string inputdate2 = "23-12-2024";
            string result2 = t7.FormatDate(inputdate2);
            Console.WriteLine(result2);

            string inputdate3 = "25-08-2024";
            string result3 = t7.FormatDate(inputdate3);
            Console.WriteLine(result3);
        }

        public static void valueOfString()
        {
            set_1.Task8 t8 = new set_1.Task8();
            string st = "Test cases";
            int result = t8.SentenceValue(st);
            Console.WriteLine($"The value of the input string {st} is {result}");


            string st1 = "ABC";
            int result1 = t8.SentenceValue(st1);
            Console.WriteLine($"The value of the input string {st1} is {result1}");

            string st2 = "hello";
            int result2 = t8.SentenceValue(st2);
            Console.WriteLine($"The valu of the input string {st2} is {result2}");
        }

        #endregion


        #region Easy_Set_II

        public static void sumDictonary()
        {
            Assignments.Easy.Set_II.Task1 t1 = new Assignments.Easy.Set_II.Task1();
            Dictionary<string, int> items = new Dictionary<string, int>()
            {
                 { "a", 400 },
                 { "b", 200 },
                 { "c", 300 }
            };

            int result = t1.SumDictionary(items);
            Console.WriteLine(result);


        }


        public static void swapElements()
        {
            set_2.Task2 t2 = new set_2.Task2();
            int[] List = [12, 35, 9, 56, 24];
            //int[] List = [1, 2, 3];
            Console.WriteLine("List befor swapping");
            for (int j = 0; j < List.Length; j++)
            {
                Console.Write(List[j]);
                Console.Write(" ");
            }
            int[] result = t2.SwapElements(List);

            Console.WriteLine(" ");
            Console.WriteLine("List after swapping");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                Console.Write(" ");
            }


            int[] List1 = [1, 2, 3];
            Console.WriteLine(" ");
            Console.WriteLine("List befor swapping");
            for (int j = 0; j < List1.Length; j++)
            {
                Console.Write(List1[j]);
                Console.Write(" ");
            }
            int[] result1 = t2.SwapElements(List1);

            Console.WriteLine(" ");
            Console.WriteLine("List after swapping");
            for (int i = 0; i < result1.Length; i++)
            {
                Console.Write(result1[i]);
                Console.Write(" ");
            }

        }

        public static void rectangle()
        {
            set_2.Rectangle rectangle1 = new set_2.Rectangle(10, 12);
            int area1 = rectangle1.CalculateArea();
            Console.WriteLine($"Area of rectangle1: {area1}");


            set_2.Rectangle rectangle2 = new set_2.Rectangle(14, 15);
            int area2 = rectangle2.CalculateArea();
            Console.WriteLine($"Area of rectangle2: {area2}");
        }

        public static void CalculatePersonAge()
        {

            set_2.Person person1 = new set_2.Person("Ferdi Odilia", "France", "1962-07-12");
            int result = person1.CalculateAge();
            Console.WriteLine(result);

            set_2.Person person2 = new set_2.Person("Shweta Maddox", "Canada", "1982-10-20");
            int resultTwo = person2.CalculateAge();
            Console.WriteLine(resultTwo);

        }

        public static void leftTianglePattern()
        {
            set_2.Task5 t5 = new set_2.Task5();
            int rows = 5;
            string results = t5.LeftTriangle(rows);
            Console.WriteLine(results);

        }

        public static void rightTrianglePattern()
        {
            set_2.Task6 t6 = new set_2.Task6();
            int rows = 5;
            string results = t6.RightTraingle(rows);
            Console.WriteLine(results);
        }

        public static void pyramidPattern()
        {
            set_2.Task7 t7 = new set_2.Task7();
            int rows = 5;
            string result = t7.Pyramid(rows);
            Console.WriteLine(result);
        }

        public static void diamondPattern()
        {
            set_2.Task8 t8 = new set_2.Task8();
            int rows = 5;
            string result = t8.Diamond(rows);
            Console.WriteLine(result);



        }


        #endregion



        #region Easy_Set_III

        public static void isPalindrome()
        {
            set_3.Task1 t1 = new set_3.Task1();
            int number = 12321;
            string result = t1.IsPalindrome(number);
            Console.WriteLine(result);

            int number1 = 123;
            string result1 = t1.IsPalindrome(number1);
            Console.WriteLine(result1);

        }

        public static void isPalindromeString()
        {
            set_3.Task3 t3 = new set_3.Task3();
            string str = "ab!ba";
            bool result = t3.IsPalindromeString(str);
            Console.WriteLine(result);

            string str1 = "racecar";
            bool result1 = t3.IsPalindromeString(str1);
            Console.WriteLine(result1);

            string str2 = "hello";
            bool result2 = t3.IsPalindromeString(str2);
            Console.WriteLine(result2);
        }


        public static void evaluateExpression()
        {
            set_3.Task2 t2 = new set_3.Task2();
            string expresssion = "3 < 7 < 11";
            string result = t2.EvaluateExpression(expresssion);
            Console.WriteLine(result);

            string expresssion1 = "13 > 44 > 33 > 1";
            string result1 = t2.EvaluateExpression(expresssion1);
            Console.WriteLine(result1);
        }

        #endregion


        #region Easy_Set_IV

        public static void importCSV()
        {
            set_4.Task1 t1 = new set_4.Task1();
            t1.ImportCSV();


        }








        #endregion

        #endregion

        #region Medium_Set_I

        public static void findWaysToClimbTop()


        {
            Assignments.Medium.Set_I.Task1 t1 = new Assignments.Medium.Set_I.Task1();
            int n = 6;
            int result = t1.FindWaysToClimbTop(n);
            Console.WriteLine(result);
        }



        public static void findMissingNumber()
        {
            Assignments.Medium.Set_I.Task2 t2 = new Assignments.Medium.Set_I.Task2();
            int[] arr = [1, 2, 3, 5];
            int size = 5;
            int result = t2.FindMissingNumber(arr, size);
            Console.WriteLine(result);


            int[] arr1 = [6, 1, 2, 8, 3, 4, 7, 10, 5];
            int size1 = 10;
            int result1 = t2.FindMissingNumber(arr1, size1);
            Console.WriteLine(result1);

        }

        public static void numberInTheString()
        {
            Assignments.Medium.Set_I.Task3 t3 = new Assignments.Medium.Set_I.Task3();
            string[] arr = ["1a", "a", "2b", "b"];
            string[] result = t3.NumbersInStrings(arr);
            foreach (string element in result)
            {
                Console.Write(element);
                Console.Write(' ');
            }
        }
       public static void sortArray()
        {
            Assignments.Medium.Set_I.Task4 t4 = new Assignments.Medium.Set_I.Task4();
            int[] result = t4.SortArray([0, 1, 2,2,0,1 ]);
            for (int j=0; j<result.Length; j++)
            {
                Console.Write(result[j]);
                Console.Write(" ");
            }
        }


        #endregion


    }
}

        

