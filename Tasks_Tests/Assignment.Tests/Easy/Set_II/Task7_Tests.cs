using Assignments.Easy.Set_II;

namespace Assignment.Tests.Easy.Set_II
{
    [TestClass]
    public class Task7_Tests
    {
        public const string pattern1 = "   *\n  ***\n *****\n*******\n";


        [DataTestMethod]
        [DataRow(4, pattern1)]
        public void PyramidPatternTests(int rows, string expected)
        {
            Task7 objTask = new Task7();
            string result = objTask.Pyramid(rows);

            Assert.AreEqual(result, expected);
        }


        [DataTestMethod]
        public void PyramidPatternTestsWithInvalidValueZeroShouldThrowArgumentException()
        {
            Task7 objTask = new Task7();
            
            Assert.ThrowsException<System.ArgumentException>(()=>objTask.Pyramid(0));
            
        }
    }
}
