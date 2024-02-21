using Assignments.Easy.Set_III;
using System.Runtime.Intrinsics.X86;

namespace Assignment.Tests.Easy.Set_III
{
    [TestClass]
    public class Task3_Tests
    {
        [DataTestMethod]
        [DataRow("malayalam", true)]
        [DataRow("MaLaYalAm", true)]
        [DataRow("MALAYALAM", true)]
        [DataRow("                 MALAYALAM  ", true)]
        [DataRow("Goa", false)]
        [DataRow("A Man, A Plan, A Canal – Panama!", true)]
        [DataRow("@#@A Man, A Plan, A Canal – Panama!", true)]
        [DataRow("@#@A Man, A Plan, A Canal – Panama!", true)]
        [DataRow("Mr. Owl ate my metal worm", true)]
        [DataRow("Do geese see God?",true)]
        [DataRow("Was it a car or a cat I saw?", true)]
        [DataRow("A palindrome is a word, number, phrase, or other sequence of symbols that reads the same backwards as forwards, such as the sentence: \"A man, a plan, a canal – Panama\"", false)]
        public void IsPalindromeStringTests(string text, bool expected)
        {
            Task3 objTask = new Task3();
            bool result = objTask.IsPalindromeString(text);

            Assert.AreEqual(result, expected);
        }
    }
}
