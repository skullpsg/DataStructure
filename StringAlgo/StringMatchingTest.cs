using NUnit.Framework;

namespace Datastructure.StringAlgo
{

    [TestFixture]
    public class StringMatchingTest
    {
        [Test]
        public void ShouldMatchStringInBruteForce()
        {
            string str1 = "vishnusankarsakthivel";
            string str2 = "sakthivel";
            var stringMatcher = new StringMatching();
            int stratingIndex = stringMatcher.MatchInBruteForce(str1, str2);

            Assert.AreEqual(stratingIndex, 12);
        }

        [Test]
        public void ShouldMatchStingKMP()
        {
            string str1 = "vishnusankarsakthivel";
            string str2 = "sak";
            var stringMatcher = new StringMatching();
            int stratingIndex = stringMatcher.MatchUsingKMP(str2, str1);

            Assert.AreEqual(stratingIndex, 12);
        }
    }
}
