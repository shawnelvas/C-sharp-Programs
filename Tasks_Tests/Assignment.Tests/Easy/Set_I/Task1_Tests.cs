using Assignments.Easy.Set_I;

namespace Assignment.Tests.Easy.Set_I
{
    [TestClass]
    public class Task1Tests
    {

        [DataTestMethod]
        [DataRow(23, 8395)]
        [DataRow(20, 7300)]
        public void CalculateAgeInDaysWithValidValue(int ageInYears, int expected)
        {
            Task1 objTask = new Task1();
            int result = objTask.CalculateAgeInDays(ageInYears);

            Assert.AreEqual(result, expected);

        }

        [DataTestMethod]
        [DataRow(-133)]
        [DataRow(-1)]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateAgeInDaysWithInvalidValueThrowsArgumentException(int ageInYears)
        {
            Task1 objTask = new Task1();
            int result = objTask.CalculateAgeInDays(ageInYears);

        }

    }
}