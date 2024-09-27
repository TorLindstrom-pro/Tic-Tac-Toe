using TicTacToe.Models;

namespace Tests.UnitTests;

public class BotTests
{
	[Fact]
	public void CreateNextBotLink_LinksBots()
	{
		// Arrange
		var firstBot = new Bot("X");
		var secondBot = new Bot("O");

		// Act
		firstBot.LinkWith(secondBot);
		
		// Assert
		var linkedBot = firstBot.NextBot;
		Assert.Equal(secondBot, linkedBot);
		Assert.Equal(firstBot, secondBot.NextBot);
		Assert.Equal(secondBot, firstBot.NextBot);
	}
}