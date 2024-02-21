using Assignments.Easy.Set_I;
using System.Reflection;

namespace Assignment.Tests.Easy.Set_I
{
    [TestClass]
    public class Task3_Tests
    {

      

        [DataTestMethod]
        [DataRow("hello", "olleh")]
        [DataRow("goa", "aog")]
        [DataRow("India", "aidnI")]
        [DataRow("", "")]
        public void ReverseString(string data, string expected)
        {
            Task3 objTask = new Task3();
            string result = objTask.ReverseString(data);

            Assert.AreEqual(result, expected);
        }

    }
}