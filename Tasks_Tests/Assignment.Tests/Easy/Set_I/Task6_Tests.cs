using Assignments.Easy.Set_I;
using System.Reflection;

namespace Assignment.Tests.Easy.Set_I
{
    [TestClass]
    public class Task6_Tests
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                int target = 10;
                string expected = "Number " + target + " found in both arrays";
                return new[]
                {
                    new object[] { new[]{ 1, 5, 8, 9, 10 }, new[] { 5, 8, 9, 10, 12, 20, 40, 60, 70 }, target, expected }
                };
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(AdditionData))]
        public void FindNumber(int[] arrayOne, int[] arrayTwo, int number, string expected)
        {
            Task6 objTask = new Task6();
            string result = objTask.FindNumber(arrayOne, arrayTwo, number);

            Assert.AreEqual(result.ToLower(), expected.ToLower());
        }


    }
}