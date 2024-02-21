using Assignments.Easy.Set_II;

namespace Assignment.Tests.Easy.Set_II
{
    [TestClass]
    public class Task5_Tests
    {
        public const string pattern1 = "1\n22\n333\n4444\n";


        [DataTestMethod]
        [DataRow(4, pattern1)]
        public void LeftTrainglePatternTests(int rows, string expected)
        {
            Task5 objTask = new Task5();
            string result = objTask.LeftTriangle(rows);

            Assert.AreEqual(result, expected);
        }


        [DataTestMethod]
        public void LeftTrainglePatternTestsWithInvalidValueZeroShouldThrowArgumentException()
        {
            Task5 objTask = new Task5();
            
            Assert.ThrowsException<System.ArgumentException>(()=>objTask.LeftTriangle(0));
            
        }
    }
}
