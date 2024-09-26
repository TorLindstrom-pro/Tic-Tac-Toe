// See https://aka.ms/new-console-template for more information

using TicTacToe.Models;

var output = new Output();
var board = new Board(output);

board.Render();