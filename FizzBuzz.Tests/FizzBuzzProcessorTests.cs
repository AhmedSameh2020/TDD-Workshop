using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzProcessorTests
    {
        [Fact]
        public void Given1AsInput_WhenCallingCalculate_ThenItShouldReturn1()
        {
            // Arrange
            int input = 1;
            string expected = "1";

            // Act
            string result = FizzBuzzProcessor.Calculate(input);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void Given2AsInput_WhenCallingCalculate_ThenItShouldReturn2()
        {
            // Arrange
            int input = 2;
            string expected = "2";

            // Act
            string result = FizzBuzzProcessor.Calculate(input);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void Given4AsInput_WhenCallingCalculate_ThenItShouldReturn4()
        {
            // Arrange
            int input = 4;
            string expected = "4";

            // Act
            string result = FizzBuzzProcessor.Calculate(input);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void Given3AsInput_WhenCallingCalculate_ThenItShouldReturnFizz()
        {
            // Arrange
            int input = 3;
            string expected = "Fizz";

            // Act
            string result = FizzBuzzProcessor.Calculate(input);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void Given9AsInput_WhenCallingCalculate_ThenItShouldReturnFizz()
        {
            // Arrange
            int input = 9;
            string expected = "Fizz";

            // Act
            string result = FizzBuzzProcessor.Calculate(input);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void Given5AsInput_WhenCallingCalculate_ThenItShouldReturnBuzz()
        {
            // Arrange
            int input = 5;
            string expected = "Buzz";

            // Act
            string result = FizzBuzzProcessor.Calculate(input);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void Given10AsInput_WhenCallingCalculate_ThenItShouldReturnBuzz()
        {
            // Arrange
            int input = 10;
            string expected = "Buzz";

            // Act
            string result = FizzBuzzProcessor.Calculate(input);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void Given15AsInput_WhenCallingCalculate_ThenItShouldReturnFizzBuzz()
        {
            // Arrange
            int input = 15;
            string expected = "FizzBuzz";

            // Act
            string result = FizzBuzzProcessor.Calculate(input);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void Given30AsInput_WhenCallingCalculate_ThenItShouldReturnFizzBuzz()
        {
            // Arrange
            int input = 30;
            string expected = "FizzBuzz";

            // Act
            string result = FizzBuzzProcessor.Calculate(input);

            // Assert
            result.Should().Be(expected);
        }
    }
}
