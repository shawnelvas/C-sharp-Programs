using Assignments.Easy.Set_III;

namespace Assignment.Tests.Easy.Set_III
{
    [TestClass]
    public class Task1_Tests
    {
        [DataTestMethod]
        [DataRow(16461, "Palindrome number")]
        [DataRow(5621, "Not palindrome number")]
        public void IsPalindromeTests(int num, string expected)
        {
            Task1 objTask = new Task1();
            string result = objTask.IsPalindrome(num);

            Assert.AreEqual(result, expected);
        }
    }
}
