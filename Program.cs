using System;
using System.Collections.Generic;

namespace Ponder_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, choiceInt, activePlayer = 0;
            string one = "empty", two = "empty", three = "empty", four = "empty", five = "empty",
                six = "empty", seven = "empty", eight = "empty", nine = "empty", finalWinner = "tie"; 
            bool winner = false;
            char choice, activeLetter;
            char[,] TTTBoard = { { '1', '2', '3', }, { '4', '5', '6', }, { '7', '8', '9' } };

            void printBoard()
            {
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (j == 2)
                        {
                            Console.Write(TTTBoard[i, j]);
                        }
                        else
                        {
                            Console.Write(TTTBoard[i, j] + " | ");
                        }
                    }
                    Console.WriteLine();
                    if (i < 2)
                    {
                        Console.WriteLine("--+---+--");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("Setting the board: \n");
            while (winner == false)
            {
                switch (activePlayer)
                {
                    case 0:
                        {
                            while (activePlayer == 0)
                            {
                                printBoard();

                                Console.WriteLine("x's turn to choose a square (1-9): ");
                                try
                                {
                                    choice = Console.ReadLine()[0];
                                }
                                catch
                                {
                                    choice = '0';
                                }
                                activeLetter = 'X';
                                choiceInt = choice - '0';
                                switch (choiceInt)
                                {
                                    case 1:
                                        if (one == "empty")
                                        {
                                            TTTBoard[0, 0] = activeLetter;
                                            one = "X";
                                            activePlayer = 1;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 2:
                                        if (two == "empty")
                                        {
                                            TTTBoard[0, 1] = activeLetter;
                                            two = "X";
                                            activePlayer = 1;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 3:
                                        if (three == "empty")
                                        {
                                            TTTBoard[0, 2] = activeLetter;
                                            three = "X";
                                            activePlayer = 1;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 4:
                                        if (four == "empty")
                                        {
                                            TTTBoard[1, 0] = activeLetter;
                                            four = "X";
                                            activePlayer = 1;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 5:
                                        if (five == "empty")
                                        {
                                            TTTBoard[1, 1] = activeLetter;
                                            five = "X";
                                            activePlayer = 1;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 6:
                                        if (six == "empty")
                                        {
                                            TTTBoard[1, 2] = activeLetter;
                                            six = "X";
                                            activePlayer = 1;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 7:
                                        if (seven == "empty")
                                        {
                                            TTTBoard[2, 0] = activeLetter;
                                            seven = "X";
                                            activePlayer = 1;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 8:
                                        if (eight == "empty")
                                        {
                                            TTTBoard[2, 1] = activeLetter;
                                            eight = "X";
                                            activePlayer = 1;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 9:
                                        if (nine == "empty")
                                        {
                                            TTTBoard[2, 2] = activeLetter;
                                            nine = "X";
                                            activePlayer = 1;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    default:
                                        Console.WriteLine("That is not a valid choice, please try again.");
                                        break;
                                }
                                Console.WriteLine("...\n");
                            }
                            break;
                        }
                    case 1:
                        {
                            while (activePlayer == 1)
                            {
                                printBoard();
                                Console.WriteLine("O's turn to choose a square (1-9): ");
                                try
                                {
                                    choice = Console.ReadLine()[0];
                                }
                                catch
                                {
                                    choice = '0';
                                }
                                activeLetter = 'O';
                                choiceInt = choice - '0';
                                switch (choiceInt)
                                {
                                    case 1:
                                        if (one == "empty")
                                        {
                                            TTTBoard[0, 0] = activeLetter;
                                            one = "O";
                                            activePlayer = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 2:
                                        if (two == "empty")
                                        {
                                            TTTBoard[0, 1] = activeLetter;
                                            two = "O";
                                            activePlayer = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 3:
                                        if (three == "empty")
                                        {
                                            TTTBoard[0, 2] = activeLetter;
                                            three = "O";
                                            activePlayer = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 4:
                                        if (four == "empty")
                                        {
                                            TTTBoard[1, 0] = activeLetter;
                                            four = "O";
                                            activePlayer = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 5:
                                        if (five == "empty")
                                        {
                                            TTTBoard[1, 1] = activeLetter;
                                            five = "O";
                                            activePlayer = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 6:
                                        if (six == "empty")
                                        {
                                            TTTBoard[1, 2] = activeLetter;
                                            six = "O";
                                            activePlayer = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 7:
                                        if (seven == "empty")
                                        {
                                            TTTBoard[2, 0] = activeLetter;
                                            seven = "O";
                                            activePlayer = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 8:
                                        if (eight == "empty")
                                        {
                                            TTTBoard[2, 1] = activeLetter;
                                            eight = "O";
                                            activePlayer = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    case 9:
                                        if (nine == "empty")
                                        {
                                            TTTBoard[2, 2] = activeLetter;
                                            nine = "O";
                                            activePlayer = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That spot is already taken. Please choose another.");
                                            break;
                                        }
                                    default:
                                        Console.WriteLine("That is not a valid choice, please try again.");
                                        break;
                                }
                                Console.WriteLine("...\n");
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                if (!(one == "empty" | two == "empty" | three == "empty" | four == "empty" | five == "empty" | six == "empty"
                        | seven == "empty" | eight == "empty" | nine == "empty"))
                {
                    winner = true;
                }
            }

            if (!(one == "empty" & two == "empty" & three == "empty" & four == "empty" & five == "empty" & six == "empty"
                & seven == "empty" & eight == "empty" & nine == "empty") & finalWinner == "tie")
            {
                Console.WriteLine("Tie Game! Better luck next time!");
            }
        }
    }
}
