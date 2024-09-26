namespace TicTacToe.Infrastructure;

public interface IOutput
{
	void Print(string line);
	void Clear();
}