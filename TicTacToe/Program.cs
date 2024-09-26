// See https://aka.ms/new-console-template for more information

using TicTacToe.Models;

var output = new Output();
var game = new Game();
var board = new Board(output, game);

board.Render();