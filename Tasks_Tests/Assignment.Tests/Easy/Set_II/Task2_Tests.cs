using Assignments.Easy.Set_II;

namespace Assignment.Tests.Easy.Set_II
{
    [TestClass]
    public class Task2_Tests
    {
        [DataTestMethod]
        [DataRow(new[] { 12, 35, 9, 56, 24}, new[] { 24, 35, 9, 56, 12 })]
        [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        public void SwapElementsTests(int[] list, int[] expected)
        {
            Task2 objTask = new Task2();
            int[] result = objTask.SwapElements(list);

            CollectionAssert.AreEqual(result, expected);

        }
    }
}
