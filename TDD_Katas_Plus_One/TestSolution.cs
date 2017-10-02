using NUnit.Framework;

namespace TDD_Katas_Plus_One
{
    [TestFixture]
    public class TestSolution
    {
        [Test]
        public void Test_when_input_1_Should_be_2()
        {
            var digits = new[] {1};
            var target = new Solution();
            var expected = new[] {2};

            var actual = target.PlusOne(digits);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_when_input_2_Should_be_3()
        {
            var digits = new[] { 2 };
            var target = new Solution();
            var expected = new[] { 3 };

            var actual = target.PlusOne(digits);

            Assert.AreEqual(expected, actual);
        }
    }
}
