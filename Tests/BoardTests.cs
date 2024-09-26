using NSubstitute;
using TicTacToe.Models;

namespace Tests;

public class BoardTests
{
	[Fact]
	public void printsGrid()
	{
		// Arrange
		var outputMock = Substitute.For<IOutput>();
		var board = new Board(outputMock);

		// Act
		board.Render();

		// Assert
		Received.InOrder(() =>
		{
			outputMock.Print("   |   |   ");
			outputMock.Print("---+---+---");
			outputMock.Print("   |   |   ");
			outputMock.Print("---+---+---");
			outputMock.Print("   |   |   ");
		});
		
	}
}