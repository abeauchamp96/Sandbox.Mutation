using FluentAssertions;
using Xunit;

namespace Mutation.Services
{
    public class BarServiceTests
    {
        private readonly IBarService service;

        public BarServiceTests() => service = new BarService();

        [Fact]
        public void IsPersonOldEnough_ShouldReturnTrue_WhenAgeIsGreaterThan18()
        {
            var isOldEnough = service.IsPersonOldEnough(20);

            isOldEnough.Should().BeTrue();
        }

        [Fact]
        public void IsPersonOldEnough_ShouldReturnFalse_WhenAgeIsLessThan18()
        {
            var isOldEnough = service.IsPersonOldEnough(12);

            isOldEnough.Should().BeFalse();
        }

        [Fact]
        public void IsPersonOldEnough_ShouldReturnTrue_WhenAgeIsEqualTo18()
        {
            var isOldEnough = service.IsPersonOldEnough(18);

            isOldEnough.Should().BeTrue();
        }
    }
}
