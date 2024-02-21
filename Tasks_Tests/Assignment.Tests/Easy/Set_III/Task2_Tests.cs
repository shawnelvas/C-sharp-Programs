using Assignments.Easy.Set_III;

namespace Assignment.Tests.Easy.Set_III
{
    [TestClass]
    public class Task2_Tests
    {
        [DataTestMethod]
        [DataRow("1 < 0", false)]
        [DataRow("13 > 44 > 33 > 1", false)]
        [DataRow("3 < 7 < 11", true)]
        public void EvaluateExpressionTests(string expression, bool expected)
        {
            Task2 objTask = new Task2();
            bool result = objTask.EvaluateExpression(expression);

            Assert.AreEqual(result, expected);
        }

        [DataTestMethod]
        public void EvaluateExpressionTestsWithInvalidExpressionShouldThrowException()
        {
            string expression = "1 = 0";
            Task2 objTask = new Task2();

            Assert.ThrowsException<InvalidOperatorException>(() => objTask.EvaluateExpression(expression));

        }
    }
}
