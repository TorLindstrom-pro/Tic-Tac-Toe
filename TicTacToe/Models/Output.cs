﻿namespace TicTacToe.Models;

internal class Output() : IOutput
{
	public void Print(string line)
	{
		Console.WriteLine(line);
	}

	public void Clear()
	{
		Console.Clear();
	}
}