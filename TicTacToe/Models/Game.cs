namespace TicTacToe.Models;

public class Game
{
	public List<Tile> Board { get; } =
	[
		new(0, 0),
		new(0, 1),
		new(0, 2),
		new(1, 0),
		new(1, 1),
		new(1, 2),
		new(2, 0),
		new(2, 1),
		new(2, 2)
	];

	public Queue<Tile> AvailableTiles { get; set; }
	
	public Game()
	{
		AvailableTiles = new Queue<Tile>(Board.OrderBy(x => Guid.NewGuid()).ToList());
	}

	public void PlayMove(string marker, Tile tile)
	{
		tile.Marker = marker;
	}

	public Tile GetTile(int x, int y)
	{
		return Board.First(t => t.X == x && t.Y == y);
	}

	public Tile GetAvailableTile()
	{
		return AvailableTiles.Dequeue();
	}
}