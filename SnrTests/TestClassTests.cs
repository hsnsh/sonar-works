using FluentAssertions;

namespace SnrTests;

public class TestClassTests
{
    [Fact]
    public void Balance_ShouldResetBalanceValue()
    {
        // Arrange
        var sut = new TestClass();

        // Act
        sut.Reset();

        // Assert
        sut.Balance.Should().Be(0);
    }

    [Fact]
    public void Add_ShouldAddToBalanceValue()
    {
        // Arrange
        var sut = new TestClass();
        var expectedValue = sut.Balance;

        // Act
        sut.Add(7);

        // Assert
        sut.Balance.Should().Be(expectedValue + 7);
    }
}