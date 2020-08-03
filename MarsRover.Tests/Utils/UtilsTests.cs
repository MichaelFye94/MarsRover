using NUnit.Framework;
using static MarsRover.Utils.Utils;

namespace MarsRover.Tests
{
    [TestFixture]
    class UtilsTests
    {
        [Test]
        [TestCase(1, 4)]
        [TestCase(4, 4)]
        public void TestMod_PositiveDividend_MatchesRemainderOp(int d, int m)
        {
            var result = Mod(d, m);
            Assert.That(result, Is.EqualTo(d % m));
        }

        [Test]
        public void TestMod_NegativeDividend_HasDivisorSign()
        {
            var result = Mod(-1, 4);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
