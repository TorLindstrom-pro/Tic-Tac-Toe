using TicTacToe.Infrastructure;

namespace TicTacToe.Models;

public class GameManager
{
	
	private readonly Board _board;
	private readonly IOutput _output;
	private readonly Game _game;
	public  Bot? Winner;
	
	public GameManager(IOutput output, Game game, Board board)
	{
		_output = output;
		_game = game;
		_board = board;
	}
	
	public GameManager()
	{
		_output = new Output();
		_game = new Game();
		_board = new Board(_output, _game);
	}

	public  void PlayGame()
	{
		var currentBot = new Bot("X");
		currentBot.CreateNextBotLink("O");
		
		while (_game.AvailableTiles.Count > 0)
		{
			_game.PlayMove(currentBot.Marker, _game.GetAvailableTile());
			_board.Render();
			
			if (_game.CheckWin(currentBot.Marker))
			{
				Winner = currentBot;
				break;
			}
			currentBot = currentBot.NextBot;
		}

		_output.Print(Winner != null ? $"Player {Winner.Marker} wins!" : "It's a draw!");
	}
}