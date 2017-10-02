using NUnit.Framework;

namespace TDD_Katas_Plus_One
{
    [TestFixture]
    public class TestSolution
    {
        Solution target = new Solution();

        [Test]
        public void Test_when_input_1_Should_be_2()
        {
            var initialDigits = new[] { 1 };
            var expected = new[] { 2 };

            AssertPlusOne(expected, initialDigits);
        }

        private void AssertPlusOne(int[] expected, int[] initialDigits)
        {
            Assert.AreEqual(
                expected, 
                target.PlusOne(initialDigits));
        }

        [Test]
        public void Test_when_input_2_Should_be_3()
        {
            var initialDigits = new[] { 2 };
            var expected = new[] { 3 };

            AssertPlusOne(expected, initialDigits);
        }
    }
}
