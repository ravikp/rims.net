using NUnit.Framework;

namespace rims.formulae.unit.tests
{
    [TestFixture]
    public class NumberExtensionsTest
    {
        [Test]
        public void ShouldBeOne()
        {
            Assert.That(NumberExtensions.SpellNumber(1), Is.EqualTo("one rupee"));
        }

        [Test]
        public void ShouldBeTwo()
        {
            Assert.That(NumberExtensions.SpellNumber(2), Is.EqualTo("two rupees"));
        }

        [Test]
        public void ShouldBeTen()
        {
            Assert.That(NumberExtensions.SpellNumber(10), Is.EqualTo("ten rupees"));
        }

        [Test]
        public void ShouldBeNineteen()
        {
            Assert.That(NumberExtensions.SpellNumber(19), Is.EqualTo("nineteen rupees"));
        }

        [Test]
        public void ShouldBeTwentyNine()
        {
            Assert.That(NumberExtensions.SpellNumber(29), Is.EqualTo("twenty nine rupees"));
        }

        [Test]
        public void ShouldBeTwoHundred()
        {
            Assert.That(NumberExtensions.SpellNumber(200), Is.EqualTo("two hundred rupees"));
        }

        [Test]
        public void ShouldBeTwoHundredAndSix()
        {
            Assert.That(NumberExtensions.SpellNumber(206), Is.EqualTo("two hundred six rupees"));
        }

        [Test]
        public void ShouldBeTwoHundredAndSixteen()
        {
            Assert.That(NumberExtensions.SpellNumber(216), Is.EqualTo("two hundred sixteen rupees"));
        }

        [Test]
        public void ShouldBeTwoHundredAndTwentySix()
        {
            Assert.That(NumberExtensions.SpellNumber(226), Is.EqualTo("two hundred twenty six rupees"));
        }

        [Test]
        public void ShouldBeOneThousand()
        {
            Assert.That(NumberExtensions.SpellNumber(1000), Is.EqualTo("one thousand rupees"));
        }

        [Test]
        public void ShouldBeThousandAndSix()
        {
            Assert.That(NumberExtensions.SpellNumber(1006), Is.EqualTo("one thousand six rupees"));
        }

        [Test]
        public void ShouldBeThousandAndSixteen()
        {
            Assert.That(NumberExtensions.SpellNumber(1016), Is.EqualTo("one thousand sixteen rupees"));
        }

        [Test]
        public void ShouldBeOneThousandOneHundredAndSixteen()
        {
            Assert.That(NumberExtensions.SpellNumber(1116), Is.EqualTo("one thousand one hundred sixteen rupees"));
        }

        [Test]
        public void ShouldBeFifteenThousand()
        {
            Assert.That(NumberExtensions.SpellNumber(15000), Is.EqualTo("fifteen thousand rupees"));
        }

        [Test]
        public void ShouldBeOneLakh()
        {
            Assert.That(NumberExtensions.SpellNumber(100000), Is.EqualTo("one lakh rupees"));
        }

        [Test]
        public void ShouldBeOneCrore()
        {
            Assert.That(NumberExtensions.SpellNumber(10000000), Is.EqualTo("one crore rupees"));
        }

        [Test]
        public void ShouldBeMoreThanCrore()
        {
            Assert.That(NumberExtensions.SpellNumber(10000000 * 50), Is.EqualTo("fifty crore rupees"));
        }

        [Test]
        public void ShouldBeWithDecimals()
        {
            Assert.That(NumberExtensions.SpellNumber(5.25), Is.EqualTo("five rupees and twenty five paise"));
            Assert.That(NumberExtensions.SpellNumber(1.25), Is.EqualTo("one rupee and twenty five paise"));
        }
    }
}