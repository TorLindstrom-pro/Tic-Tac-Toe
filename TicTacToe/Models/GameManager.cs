namespace TicTacToe.Models;

public class GameManager
{
	
	private readonly Renderer _renderer;
	private readonly Game _game;
	public  Bot? Winner;
	
	public GameManager(Game game, Renderer renderer)
	{
		_game = game;
		_renderer = renderer;
	}
	
	public GameManager()
	{
		_game = new Game();
		_renderer = new Renderer(_game);
	}

	public  void PlayGame()
	{
		var currentBot = new Bot("X");
		currentBot.CreateNextBotLink("O");
		
		while (_game.AvailableTiles.Count > 0)
		{
			_game.GetAvailableTile().Marker = currentBot.Marker;
			_renderer.Render();
			
			if (_game.CheckWin(currentBot.Marker))
			{
				Winner = currentBot;
				break;
			}
			currentBot = currentBot.NextBot;
		}

		if (Winner != null) _renderer.PrintWinner(Winner);
		else _renderer.PrintDraw();
	}
}