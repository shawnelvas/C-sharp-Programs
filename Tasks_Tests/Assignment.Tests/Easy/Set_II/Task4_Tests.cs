using Assignments.Easy.Set_II;

namespace Assignment.Tests.Easy.Set_II
{
    [TestClass]
    public class Task4_Tests
    {
        [DataTestMethod]
        [DataRow("Ferdi Odilia", "France", "1962-07-12", 61)]
        [DataRow("Shweta Maddox", "Canada", "1982-10-20", 41)]
        public void CalculatePersonAgeTests(string name, string country, string dob, int expected)
        {
            Person objTask = new Person(name,country,dob);
            int result = objTask.CalculateAge();

            Assert.AreEqual(result, expected);

        }
    }
}
