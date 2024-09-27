using TicTacToe.Models;

namespace Tests.UnitTests;

public class BotTests
{
	[Fact]
	public void CreateNextBotLink_LinksBots()
	{
		// Arrange
		var bot = new Bot("X");
		
		// Act
		var result = bot.CreateNextBotLink("O");
		
		// Assert
		Assert.Equal("O", result.Marker);
		Assert.Equal(bot, result.NextBot);
		Assert.Equal(result, bot.NextBot);
	}
}