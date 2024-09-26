namespace TicTacToe.Models;

public class Board(IOutput output)
{
	private const string HorizontalDivider = "---+---+---";

	public void Render()
	{
		output.Clear();
		output.Print("   |   |   ");
		output.Print(HorizontalDivider);
		output.Print("   |   |   ");
		output.Print(HorizontalDivider);
		output.Print("   |   |   ");
		
	}
}