

using Assignments.Easy.Set_I;
using System.Reflection;

namespace Assignment.Tests.Easy.Set_I
{
    [TestClass]
    public class Task4_Tests
    {

      

        [DataTestMethod]
        [DataRow(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [DataRow(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        [DataRow(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        public void SumTwoNumbersWithValidValue(int[] numbers, int target, int[] expected)
        {
            Task4 objTask = new Task4();
            int[] result = objTask.SumTwoNumbers(numbers, target);

            CollectionAssert.AreEqual(result, expected);
        }

        [DataTestMethod]
        [DataRow(new[] { 2, 7, 11, 15 }, 119)]
        [DataRow(new[] { 3 }, 6)]
        [DataRow(new[] { 3, 2, 114 }, 6)]
        [ExpectedException(typeof(ArgumentException))]
        public void SumTwoNumbersWithInvalidValueThrowsArgumentException(int[] numbers, int target)
        {
            Task4 objTask = new Task4();
            int[] result = objTask.SumTwoNumbers(numbers, target);

        }

      
    }
}