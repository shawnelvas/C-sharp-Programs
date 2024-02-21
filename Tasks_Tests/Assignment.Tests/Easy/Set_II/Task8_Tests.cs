using Assignments.Easy.Set_II;

namespace Assignment.Tests.Easy.Set_II
{
    [TestClass]
    public class Task8_Tests
    {
        public const string pattern1 = "   *\n  ***\n *****\n*******\n *****\n  ***\n   *\n";


        [DataTestMethod]
        [DataRow(4, pattern1)]
        public void DiamondPatternTests(int rows, string expected)
        {
            Task8 objTask = new Task8();
            string result = objTask.Diamond(rows);

            Assert.AreEqual(result, expected);
        }


        [DataTestMethod]
        public void DiamondPatternTestsWithInvalidValueZeroShouldThrowArgumentException()
        {
            Task8 objTask = new Task8();
            
            Assert.ThrowsException<System.ArgumentException>(()=>objTask.Diamond(0));
            
        }
    }
}
