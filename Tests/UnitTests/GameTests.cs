using TicTacToe.Models;

namespace Tests.UnitTests;

public class GameTests
{
	[Fact]
	public void PlayMove_MarksTile()
	{
		// Arrange
		var game = new Game();
		var tile = game.Board.First(t => t is { X: 0, Y: 0 });

		// Act
		game.PlayMove("X", tile);

		// Assert
		Assert.Equal("X", tile.Marker);
	}
	
	[Fact]
	public void ShuffleTiles_SortsAvailableTilesRandomly()
	{
		// Arrange
		var game = new Game();

		// Act
		game.ShuffleTiles();

		// Assert
		Assert.NotEqual(
			["0,0", "0,1", "0,2", "1,0", "1,1", "1,2", "2,0", "2,1", "2,2"],
			game.availableTiles.Select(t => t.X + "," + t.Y));
	}
}