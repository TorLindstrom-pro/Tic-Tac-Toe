namespace TicTacToe.Models;

public class Game
{
	public string[,] Board { get; } = new string[3, 3];

	public void PlayMove(string marker, Tile tile)
	{
		Board[tile.X, tile.Y] = marker;
	}
}