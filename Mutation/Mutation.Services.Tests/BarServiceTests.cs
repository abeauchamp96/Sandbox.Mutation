using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mutation.Services.Tests
{
    [TestClass]
    public class BarServiceTests
    {
        private readonly IBarService service;

        public BarServiceTests() => service = new BarService();

        [TestMethod]
        public void IsPersonOldEnough_ShouldReturnTrue_WhenAgeIsGreaterThan18()
        {
            var isOldEnough = service.IsPersonOldEnough(20);

            isOldEnough.Should().BeTrue();
        }

        [TestMethod]
        public void IsPersonOldEnough_ShouldReturnFalse_WhenAgeIsLessThan18()
        {
            var isOldEnough = service.IsPersonOldEnough(12);

            isOldEnough.Should().BeFalse();
        }

        [TestMethod]
        public void IsPersonOldEnough_ShouldReturnTrue_WhenAgeIsEqualTo18()
        {
            var isOldEnough = service.IsPersonOldEnough(18);

            isOldEnough.Should().BeTrue();
        }
    }
}
