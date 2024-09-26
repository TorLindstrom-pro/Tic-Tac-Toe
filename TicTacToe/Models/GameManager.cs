using TicTacToe.Infrastructure;

namespace TicTacToe.Models;

internal abstract class GameManager
{
	public static void StartGame()
	{
		var output = new Output();
		var game = new Game();
		var board = new Board(output, game);

		board.Render();
	}
}