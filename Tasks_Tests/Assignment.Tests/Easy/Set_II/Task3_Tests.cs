using Assignments.Easy.Set_II;

namespace Assignment.Tests.Easy.Set_II
{
    [TestClass]
    public class Task3_Tests
    {
        [DataTestMethod]
        [DataRow(10, 12, 120)]
        [DataRow(14, 15, 210)]
        public void RectangleAreaTests(int width, int height, int expected)
        {
            Rectangle objTask = new Rectangle(width, height);
            int result = objTask.CalculateArea();

            Assert.AreEqual(result, expected);

        }
    }
}
