using NUnit.Framework;

namespace Datastructure.DynamicProblem.CoinChange
{
    [TestFixture]
    class CoinChangeTest
    {

        [Test]
        public void ShouldReturnPaths() {
            CoinsChange coins = new CoinsChange();
            int[] coinAvaliable = new int[] { 1, 2, 5 };
            int possibilities = coins.GetChangePossibilities(5, 0, coinAvaliable);
            Assert.AreEqual(possibilities, 4);
        }
    }
}
