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
}