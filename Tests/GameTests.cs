using TicTacToe.Models;

namespace Tests;

public class GameTests
{
	[Fact]
	public void PlayMove_MarksTile()
	{
		// Arrange
		var game = new Game();

		// Act
		game.PlayMove("X", new Tile(0, 0));

		// Assert
		Assert.Equal("X", game.Board[0, 0]);
	}
}