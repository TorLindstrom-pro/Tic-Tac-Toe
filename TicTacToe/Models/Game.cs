﻿namespace TicTacToe.Models;

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

	public Tile GetTile(int x, int y)
	{
		return Board.First(t => t.X == x && t.Y == y);
	}

	public Tile GetAvailableTile()
	{
		return AvailableTiles.Dequeue();
	}

	public bool CheckWin(string marker)
	{
		var rows = Board.GroupBy(t => t.X);
		var anyRow = rows.Any(r => r.All(t => t.Marker == marker));
		
		var columns = Board.GroupBy(t => t.Y);
		var anyColumn = columns.Any(r => r.All(t => t.Marker == marker));
		
		var diagonals = new List<List<Tile>>
		{
			new() {GetTile(0, 0), GetTile(1, 1), GetTile(2, 2)},
			new() {GetTile(0, 2), GetTile(1, 1), GetTile(2, 0)}
		};
		var anyDiagonal = diagonals.Any(d => d.All(t => t.Marker == marker));
		
		return anyRow || anyColumn || anyDiagonal;
	}
}