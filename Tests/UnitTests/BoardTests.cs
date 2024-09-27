using NSubstitute;
using TicTacToe.Infrastructure;
using TicTacToe.Models;

namespace Tests.UnitTests;

public class BoardTests
{
	[Fact]
	public void Render_PrintsGrid()
	{
		// Arrange
		var outputMock = Substitute.For<IOutput>();
		var board = new Board(outputMock, new Game());

		// Act
		board.Render();

		// Assert
		Received.InOrder(() =>
		{
			outputMock.Clear();
			outputMock.Print("   |   |   ");
			outputMock.Print("---+---+---");
			outputMock.Print("   |   |   ");
			outputMock.Print("---+---+---");
			outputMock.Print("   |   |   ");
		});
		
	}
	
	[Fact]
	public void Render_GameMoves_ArePrinted()
	{
		// Arrange
		var outputMock = Substitute.For<IOutput>();
		var game = new Game();
		
		game.PlayMove("X", game.GetTile(0, 0));
		game.PlayMove("O", game.GetTile(1, 0));
		game.PlayMove("X", game.GetTile(2, 1));
		
		var board = new Board(outputMock, game);

		// Act
		board.Render();

		// Assert
		Received.InOrder(() =>
		{
			outputMock.Clear();
			outputMock.Print(" X |   |   ");
			outputMock.Print("---+---+---");
			outputMock.Print(" O |   |   ");
			outputMock.Print("---+---+---");
			outputMock.Print("   | X |   ");
		});
		
	}
}