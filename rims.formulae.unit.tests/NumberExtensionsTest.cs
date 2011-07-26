using NUnit.Framework;

namespace rims.formulae.unit.tests
{
    [TestFixture]
    public class NumberExtensionsTest
    {
        [Test]
        public void ShouldBeOne()
        {
            Assert.That(NumberExtensions.SpellNumber(1), Is.EqualTo("one"));
        }

        [Test]
        public void ShouldBeTwo()
        {
            Assert.That(NumberExtensions.SpellNumber(2), Is.EqualTo("two"));
        }

        [Test]
        public void ShouldBeTen()
        {
            Assert.That(NumberExtensions.SpellNumber(10), Is.EqualTo("ten"));
        }

        [Test]
        public void ShouldBeNineteen()
        {
            Assert.That(NumberExtensions.SpellNumber(19), Is.EqualTo("nineteen"));
        }

        [Test]
        public void ShouldBeTwentyNine()
        {
            Assert.That(NumberExtensions.SpellNumber(29), Is.EqualTo("twenty nine"));
        }

        [Test]
        public void ShouldBeTwoHundred()
        {
            Assert.That(NumberExtensions.SpellNumber(200), Is.EqualTo("two hundred"));
        }

        [Test]
        public void ShouldBeTwoHundredAndSix()
        {
            Assert.That(NumberExtensions.SpellNumber(206), Is.EqualTo("two hundred six"));
        }

        [Test]
        public void ShouldBeTwoHundredAndSixteen()
        {
            Assert.That(NumberExtensions.SpellNumber(216), Is.EqualTo("two hundred sixteen"));
        }

        [Test]
        public void ShouldBeTwoHundredAndTwentySix()
        {
            Assert.That(NumberExtensions.SpellNumber(226), Is.EqualTo("two hundred twenty six"));
        }

        [Test]
        public void ShouldBeOneThousand()
        {
            Assert.That(NumberExtensions.SpellNumber(1000), Is.EqualTo("one thousand"));
        }

        [Test]
        public void ShouldBeThousandAndSix()
        {
            Assert.That(NumberExtensions.SpellNumber(1006), Is.EqualTo("one thousand six"));
        }

        [Test]
        public void ShouldBeThousandAndSixteen()
        {
            Assert.That(NumberExtensions.SpellNumber(1016), Is.EqualTo("one thousand sixteen"));
        }

        [Test]
        public void ShouldBeOneThousandOneHundredAndSixteen()
        {
            Assert.That(NumberExtensions.SpellNumber(1116), Is.EqualTo("one thousand one hundred sixteen"));
        }

        [Test]
        public void ShouldBeFifteenThousand()
        {
            Assert.That(NumberExtensions.SpellNumber(15000), Is.EqualTo("fifteen thousand"));
        }

        [Test]
        public void ShouldBeOneLakh()
        {
            Assert.That(NumberExtensions.SpellNumber(100000), Is.EqualTo("one lakh"));
        }

        [Test]
        public void ShouldBeOneCrore()
        {
            Assert.That(NumberExtensions.SpellNumber(10000000), Is.EqualTo("one crore"));
        }

        [Test]
        public void ShouldBeMoreThanCrore()
        {
            Assert.That(NumberExtensions.SpellNumber(10000000 * 50), Is.EqualTo("fifty crore"));
        }

        [Test]
        public void ShouldBeWithDecimals()
        {
            Assert.That(NumberExtensions.SpellNumber(5.25), Is.EqualTo("five and twenty five paise"));
            Assert.That(NumberExtensions.SpellNumber(1.25), Is.EqualTo("one and twenty five paise"));
        }
    }
}