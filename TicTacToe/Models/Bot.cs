namespace TicTacToe.Models;

public class Bot(string marker)
{
	public string Marker { get; } = marker;
	public Bot NextBot { get; set; }

	public void LinkWith(Bot bot)
	{
		NextBot = bot;
		bot.NextBot = this;
	}
}