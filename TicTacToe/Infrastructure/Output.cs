namespace TicTacToe.Infrastructure;

internal class Output : IOutput
{
	public void Print(string line)
	{
		Console.WriteLine(line);
		Thread.Sleep(1000);
	}

	public void Clear()
	{
		Console.Clear();
	}
}