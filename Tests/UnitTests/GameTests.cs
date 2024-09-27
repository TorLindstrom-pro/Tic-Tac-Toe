using TicTacToe.Models;

namespace Tests.UnitTests;

public class GameTests
{
	[Fact]
	public void PlayMove_MarksTile()
	{
		// Arrange
		var game = new Game();
		var tile = game.GetTile(0, 0);

		// Act
		game.PlayMove("X", tile);

		// Assert
		Assert.Equal("X", tile.Marker);
	}
	
	[Fact]
	public void ConstuctingAGame_SortsAvailableTilesRandomly()
	{
		// Act
		var game = new Game();

		// Assert
		Assert.NotEqual(
			["0,0", "0,1", "0,2", "1,0", "1,1", "1,2", "2,0", "2,1", "2,2"],
			game.AvailableTiles.Select(t => t.X + "," + t.Y));
	}
	
	[Fact]
	public void GetTile_GetsTile()
	{
		// Arrange
		var game = new Game();

		// Act
		var result = game.GetTile(2, 1);

		// Assert
		Assert.Equal(game.Board.First(t => t is { X: 2, Y: 1 }), result);
	}
	
	[Fact]
	public void GetAvailableTile_MakesTileUnavailable()
	{
		// Arrange
		var game = new Game();
		var availableTilesCount = game.AvailableTiles.Count;

		// Act
		var result = game.GetAvailableTile();

		// Assert
		Assert.Equal(availableTilesCount - 1, game.AvailableTiles.Count);
	}
}