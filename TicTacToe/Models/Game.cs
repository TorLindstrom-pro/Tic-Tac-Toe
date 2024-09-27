namespace TicTacToe.Models;

public class Game
{
	public List<Tile> Board { get; } =
	[
		new Tile(0, 0),
		new Tile(0, 1),
		new Tile(0, 2),
		new Tile(1, 0),
		new Tile(1, 1),
		new Tile(1, 2),
		new Tile(2, 0),
		new Tile(2, 1),
		new Tile(2, 2)
	];

	public List<Tile> availableTiles { get; set; }

	public void PlayMove(string marker, Tile tile)
	{
		tile.Marker = marker;
	}
	
	public void ShuffleTiles()
	{
		availableTiles = Board.OrderBy(x => Guid.NewGuid()).ToList();
	}

	public Tile GetTile(int x, int y)
	{
		return Board.First(t => t.X == x && t.Y == y);
	}
}