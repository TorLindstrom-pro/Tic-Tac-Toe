﻿namespace TicTacToe.Models;

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

public interface IOutput
{
	void Print(string line);
	void Clear();
}