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
            Assert.That(NumberExtensions.SpellNumber(2),Is.EqualTo("two"));
        }
    }
}