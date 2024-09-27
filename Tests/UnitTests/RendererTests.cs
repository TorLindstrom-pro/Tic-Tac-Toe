using NSubstitute;
using TicTacToe.Infrastructure;
using TicTacToe.Models;

namespace Tests.UnitTests;

public class RendererTests
{
	[Fact]
	public void Render_PrintsGrid()
	{
		// Arrange
		var outputMock = Substitute.For<IOutput>();
		var board = new Renderer(outputMock, new Game());

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
		
		game.GetTile(0, 0).Marker = "X";
		game.GetTile(1, 0).Marker = "O";
		game.GetTile(2, 1).Marker = "X";
		
		var board = new Renderer(outputMock, game);

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

	[Fact]
	public void PrintWinner_PrintsWinnerMessage()
	{
		// Arrange
		var outputMock = Substitute.For<IOutput>();
		var game = new Game();
		var renderer = new Renderer(outputMock, game);
		var winner = new Bot("X");

		// Act
		renderer.PrintWinner(winner);

		// Assert
		outputMock.Received().Print("Player X wins!");
	}

	[Fact]
	public void PrintDraw_PrintsDrawMessage()
	{
		// Arrange
		var outputMock = Substitute.For<IOutput>();
		var game = new Game();
		var renderer = new Renderer(outputMock, game);

		// Act
		renderer.PrintDraw();

		// Assert
		outputMock.Received().Print("It's a draw!");
	}
}