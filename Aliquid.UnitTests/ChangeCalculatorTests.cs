namespace Aliquid.UnitTests
{
    using Application;
    using NUnit.Framework;

    public class ChangeCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChangeCalculator_GetChange_ReturnsExpected()
        {
            var sut = new ChangeCalculator();

            var result = sut.GetChange(5, 0.99m);

            Assert.AreEqual(new int[] {1, 0, 0, 0, 0, 4}, result);
        }
        
        [Test]
        public void ChangeCalculator_GetChange_ReturnsExpected2()
        {
            var sut = new ChangeCalculator();

            var result = sut.GetChange(3.14m, 1.99m);

            Assert.AreEqual(new int[] {0, 1, 1, 0, 0, 1}, result);
        }
        
        [Test]
        public void ChangeCalculator_GetChange_ReturnsExpected3()
        {
            var sut = new ChangeCalculator();

            var result = sut.GetChange(4, 3.14m);

            Assert.AreEqual(new int[] {1, 0, 1, 1, 1, 0}, result);
        }
        
        [Test]
        public void ChangeCalculator_GetChange_ReturnsExpected4()
        {
            var sut = new ChangeCalculator();

            var result = sut.GetChange(0.45m, 0.34m);

            Assert.AreEqual(new int[] {1, 0, 1, 0, 0, 0}, result);
        }
    }
}