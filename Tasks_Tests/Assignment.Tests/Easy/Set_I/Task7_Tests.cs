using Assignments.Easy.Set_I;
using System.Reflection;

namespace Assignment.Tests.Easy.Set_I
{
    [TestClass]
    public class Task7_Tests
    {

        [DataTestMethod]
        [DataRow("01-10-2021", "1st Oct 2021")]
        [DataRow("20-10-2021", "20th Oct 2021")]
        public void FormatDateWithValidValue(string inputDate, string expected)
        {
            Task7 objTask = new Task7();
            string result = objTask.FormatDate(inputDate);

            Assert.AreEqual(result, expected);
        }

        [DataTestMethod]
        [DataRow("1-10-2021")]
        [DataRow("40-10-2021")]
        [ExpectedException(typeof(FormatException))]
        public void FormatDateWithInvalidValueThrowsFormatException(string inputDate)
        {
            Task7 objTask = new Task7();
            string result = objTask.FormatDate(inputDate);

        }

        
    }
}