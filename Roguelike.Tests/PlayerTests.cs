using Roguelike.Game;
using Xunit;

namespace Roguelike.Tests;

public class PlayerTests
{
    [Fact]
    public void TakeDamage_WhenDamageIsPositive_ShouldReduceHealth()
    {
        // Arrange
        Player player = new Player("Luiz", 100, 25);

        // Act
        player.TakeDamage(30);

        // Assert
        Assert.Equal(70, player.Health);
    }

    [Fact]
    public void TakeDamage_WhenDamageIsGreaterThanHealth_ShouldSetHealthToZero()
    {
        // Arrange
        Player player = new Player("Luiz", 100, 25);

        // Act
        player.TakeDamage(150);

        // Assert
        Assert.Equal(0, player.Health);
        Assert.False(player.IsAlive);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-10)]
    public void TakeDamage_WhenDamageIsZeroOrNegative_ShouldNotChangeHealth(
        int damage
    )
    {
        // Arrange
        Player player = new Player("Luiz", 100, 25);

        // Act
        player.TakeDamage(damage);

        // Assert
        Assert.Equal(100, player.Health);
    }
}