using Assignments.Easy.Set_I;
using System.Reflection;

namespace Assignment.Tests.Easy.Set_I
{
    [TestClass]
    public class Task5_Tests
    {

        [DataTestMethod]
        [DataRow(2, 7200)]
        [DataRow(10, 36000)]
        [DataRow(24, 86400)]
        public void ConvertHoursToSecondsWithValidValue(int hours, int expected)
        {
            Task5 objTask = new Task5();
            int result = objTask.ConvertHoursToSeconds(hours);

            Assert.AreEqual(result, expected);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertHoursToSecondsWithInvalidValueThrowsArgumentException(int hours)
        {
            Task5 objTask = new Task5();
            int result = objTask.ConvertHoursToSeconds(hours);

        }
        
    }
}