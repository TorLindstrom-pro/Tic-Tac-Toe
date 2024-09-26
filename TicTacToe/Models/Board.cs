namespace TicTacToe.Models;

public class Board(IOutput output, Game game)
{
	private const string HorizontalDivider = "---+---+---";

	public void Render()
	{
		output.Clear();
		output.Print($" {GetMark(0,0)} | {GetMark(0, 1)} | {GetMark(0, 2)} ");
		output.Print(HorizontalDivider);
		output.Print($" {GetMark(1, 0)} | {GetMark(1, 1)} | {GetMark(1, 2)} ");
		output.Print(HorizontalDivider);
		output.Print($" {GetMark(2, 0)} | {GetMark(2, 1)} | {GetMark(2, 2)} ");
		
	}

	private string GetMark(int x, int y)
	{
		return game.Board[x, y] ?? " ";
	}
}