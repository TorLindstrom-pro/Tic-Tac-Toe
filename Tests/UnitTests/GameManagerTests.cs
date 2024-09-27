using NSubstitute;
using TicTacToe.Infrastructure;
using TicTacToe.Models;

namespace Tests.UnitTests;

public class GameManagerTests
{
	[Fact]
	public void PlayGame_EndsInWinOrDraw()
	{
		// Arrange
		var game = new Game();
		var outputMock = Substitute.For<IOutput>();
		var board = new Renderer(outputMock, game);

		var gameManager = new GameManager(game, board);

		// Act
		gameManager.PlayGame();

		// Assert
		if (gameManager.Winner is not null)
		{
			Assert.True(game.CheckWin(gameManager.Winner.Marker));
			outputMock.Received().Print($"Player {gameManager.Winner.Marker} wins!");
		}
		else
		{
			Assert.Empty(game.AvailableTiles);
			outputMock.Received().Print("It's a draw!");
		}
	}
}