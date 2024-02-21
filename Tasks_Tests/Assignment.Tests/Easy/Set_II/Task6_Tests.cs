using Assignments.Easy.Set_II;

namespace Assignment.Tests.Easy.Set_II
{
    [TestClass]
    public class Task6_Tests
    {
        public const string pattern1 = "   1\n  22\n 333\n4444\n";


        [DataTestMethod]
        [DataRow(4, pattern1)]
        public void RightTrainglePatternTests(int rows, string expected)
        {
            Task6 objTask = new Task6();
            string result = objTask.RightTraingle(rows);

            Assert.AreEqual(result, expected);
        }


        [DataTestMethod]
        public void RightTrainglePatternTestsWithInvalidValueZeroShouldThrowArgumentException()
        {
            Task6 objTask = new Task6();
            
            Assert.ThrowsException<System.ArgumentException>(()=>objTask.RightTraingle(0));
            
        }
    }
}
