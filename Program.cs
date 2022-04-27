using System;
using System.Collections.Generic;

namespace Ponder_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, choiceInt;
            bool one = true, two = true, three = true, four = true, five = true, 
                six = true, seven = true, eight = true, nine = true, activePlayer = false,
                winner = false;
            char choice, activeLetter;
            char[,] TTTBoard = {{'1','2','3',}, {'4','5','6',}, {'7','8','9'} };

            Console.WriteLine("Setting the board: \n");
            do {

            while (!activePlayer)
            {
                for (i = 0; i < 3; i++) {
                for (j = 0; j < 3; j++) {
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
                if (i < 2){
                    Console.WriteLine("--+---+--");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("x's turn to choose a square (1-9): ");
            choice = Console.ReadLine()[0];
            activeLetter = 'X';
            choiceInt = choice - '0';
            switch (choiceInt)
            {
                case 1:
                    if (one)
                    {
                    TTTBoard[0, 0] = activeLetter;
                    one = false;
                    activePlayer = true;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = false;
                        break;
                    }
                case 2:
                    if (two)
                    {
                    TTTBoard[0, 1] = activeLetter;
                    two = false;
                    activePlayer = true;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = false;
                        break;
                    }
                case 3:
                    if (three)
                    {
                    TTTBoard[0, 2] = activeLetter;
                    three = false;
                    activePlayer = true;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = false;
                        break;
                    }
                case 4:
                    if (four)
                    {
                    TTTBoard[1, 0] = activeLetter;
                    four = false;
                    activePlayer = true;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = false;
                        break;
                    }
                case 5:
                    if (five)
                    {
                    TTTBoard[1, 1] = activeLetter;
                    five = false;
                    activePlayer = true;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = false;
                        break;
                    }
                case 6:
                    if (six)
                    {
                    TTTBoard[1, 2] = activeLetter;
                    six = false;
                    activePlayer = true;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = false;
                        break;
                    }
                case 7:
                    if (seven)
                    {
                    TTTBoard[2, 0] = activeLetter;
                    seven = false;
                    activePlayer = true;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = false;
                        break;
                    }
                case 8:
                    if (eight)
                    {
                    TTTBoard[2, 1] = activeLetter;
                    eight = false;
                    activePlayer = true;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = false;
                        break;
                    }
                case 9:
                    if (nine)
                    {
                    TTTBoard[2, 2] = activeLetter;
                    nine = false;
                    activePlayer = true;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = false;
                        break;
                    }
                default:
                    Console.WriteLine("That is not a valid choice, please try again.");
                    activePlayer = false;
                    break;
            }
                Console.WriteLine("...\n");
            }
            if (!(one == true | two == true | three == true | four == true | five == true | six == true
                | seven == true | eight == true | nine == true))
                {
                    winner = true;
                }
            if (!winner)
            while (activePlayer) {
                for (i = 0; i < 3; i++) {
                for (j = 0; j < 3; j++) {
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
                if (i < 2){
                    Console.WriteLine("--+---+--");
                }
                else
                {
                    Console.WriteLine();
                }
            }
                Console.WriteLine("O's turn to choose a square (1-9): ");
            choice = Console.ReadLine()[0];
            activeLetter = 'O';
            choiceInt = choice - '0';
            switch (choiceInt)
            {
                case 1:
                    if (one)
                    {
                    TTTBoard[0, 0] = activeLetter;
                    one = false;
                    activePlayer = false;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = true;
                        break;
                    }
                case 2:
                    if (two)
                    {
                    TTTBoard[0, 1] = activeLetter;
                    two = false;
                    activePlayer = false;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = true;
                        break;
                    }
                case 3:
                    if (three)
                    {
                    TTTBoard[0, 2] = activeLetter;
                    three = false;
                    activePlayer = false;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = true;
                        break;
                    }
                case 4:
                    if (four)
                    {
                    TTTBoard[1, 0] = activeLetter;
                    four = false;
                    activePlayer = false;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = true;
                        break;
                    }
                case 5:
                    if (five)
                    {
                    TTTBoard[1, 1] = activeLetter;
                    five = false;
                    activePlayer = false;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = true;
                        break;
                    }
                case 6:
                    if (six)
                    {
                    TTTBoard[1, 2] = activeLetter;
                    six = false;
                    activePlayer = false;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = true;
                        break;
                    }
                case 7:
                    if (seven)
                    {
                    TTTBoard[2, 0] = activeLetter;
                    seven = false;
                    activePlayer = false;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = true;
                        break;
                    }
                case 8:
                    if (eight)
                    {
                    TTTBoard[2, 1] = activeLetter;
                    eight = false;
                    activePlayer = false;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = true;
                        break;
                    }
                case 9:
                    if (nine)
                    {
                    TTTBoard[2, 2] = activeLetter;
                    nine = false;
                    activePlayer = false;
                    break;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another.");
                        activePlayer = true;
                        break;
                    }
                default:
                    Console.WriteLine("That is not a valid choice, please try again.");
                    activePlayer = true;
                    break;
            }
                Console.WriteLine("...\n");
            }
            } while (winner == false);
            
            if (one == false & two == false & three == false & four == false & five == false & six == false
                & seven == false & eight == false & nine == false)
            {
                Console.WriteLine("Tie Game! Better luck next time!");
            }
        }
    }
}
