namespace TicTacToe.Models;

public class Bot(string marker)
{
	public string Marker { get; } = marker;
	public Bot NextBot { get; set; }

	public Bot CreateNextBotLink(string marker)
	{
		var nextBot = new Bot(marker)
		{
			NextBot = this
		};

		NextBot = nextBot;
		return nextBot;
	}
}