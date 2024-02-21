using Assignments.Easy.Set_I;
using System.Reflection;

namespace Assignment.Tests.Easy.Set_I
{
    [TestClass]
    public class Task8_Tests
    {
        [DataTestMethod]
        [DataRow("Test", 104)]
        [DataRow("Test cases", 201)]
        [DataRow("a @#!  a", 22)]
        [DataRow("123", 0)]
        [DataRow("123 abc", 36)]
        public void Test_SentenceValue(string text, int expected)
        {
            Task8 objTask = new Task8();
            int result = objTask.SentenceValue(text);

            Assert.AreEqual(result, expected);
        }
    }
}