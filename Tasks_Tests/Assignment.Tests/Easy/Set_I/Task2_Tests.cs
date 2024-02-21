using Assignments.Easy.Set_I;
using System.Reflection;

namespace Assignment.Tests.Easy.Set_I
{
    [TestClass]
    public class Task2_Tests
    {   
        [DataTestMethod]
        [DataRow(23, 725328000)]
        [DataRow(1, 31536000)]
        public void CalculateAgeInSecondsWithValidValue(int ageInYears, int expected)
        {
            Task2 objTask = new Task2();
            int result = objTask.CalculateAgeInSeconds(ageInYears);

            Assert.AreEqual(result, expected);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateAgeInSecondsWithInvalidValueThrowsArgumentException(int ageInYears)
        {
            Task2 objTask = new Task2();
            int result = objTask.CalculateAgeInSeconds(ageInYears);

        }

        
    }
}