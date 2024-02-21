using Assignments.Easy.Set_II;

namespace Assignment.Tests.Easy.Set_II
{
    [TestClass]
    public class Task1_Tests
    {
      public static Dictionary<string, int> items1 = new Dictionary<string, int>()
            {
                { "a", 400 },
                { "b", 200 },
                { "c", 300 }
            };

        public static Dictionary<string, int> items2 = new Dictionary<string, int>()
            {
                { "a", 35 },
                { "b", 18 },
                { "c", 45 }
            };

        public static IEnumerable<object[]> TestData1
        {
            get
            {               
                return new[]
                {
                    new object[] { items1, 900 }
                };
            }
        }

        public static IEnumerable<object[]> TestData2
        {
            get
            {
                return new[]
                {
                    new object[] { items2, 98 }
                };
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData1))]
        [DynamicData(nameof(TestData2))]
        public void SumDictionaryTests(Dictionary<string, int> items, int expected)
        {
            Task1 objTask = new Task1();
            int result = objTask.SumDictionary(items);

            Assert.AreEqual(result, expected);

        }
    }
}
