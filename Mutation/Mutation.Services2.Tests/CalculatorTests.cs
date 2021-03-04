using FluentAssertions;
using Xunit;

namespace Mutation.Services2.Tests
{
    public class CalculatorTests
    {
        private readonly ICalculator calculator;

        public CalculatorTests()
        {
            calculator = new Calculator();
        }

        [Fact]
        public void Calculator_ShouldDoTheSum()
        {
            var result = calculator.Sum(1, 2, 3);

            result.Should().Be(6);
        }
    }
}
