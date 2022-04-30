using System;
using System.Collections.Generic;

// CSE 210 01 Ponder - Logan Butler

namespace Ponder_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Establish variables. Number name variables are set to 4 to evaluate the
            // winner. X's are worth 0 and O's are worth 1, so any winning row will add
            // up to either 0 or 3 and with the default at 4 it can't be miscalculated.
            int i, j, choiceInt, activePlayer = 0,
                one = 4, two = 4, three = 4, four = 4, five = 4,
                six = 4, seven = 4, eight = 4, nine = 4;
            string finalWinner = "tie", playAgain = "y";
            bool winner = false;
            char choice, activeLetter;

            // Declares the array used to print the board to console
            char[,] TTTBoard = { { '1', '2', '3', }, { '4', '5', '6', }, { '7', '8', '9' } };

            // This function prints the contents of the TTTBoard array to the console
            // to give the player an idea of the current board state.

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

            // This function checks if a player has won the game. 
            void checkWinner()
            {
                if (one + two + three == 0 | one + four + seven == 0 | one + five + nine == 0 |
                    two + five + eight == 0 | three + five + seven == 0 | three + six + nine == 0 |
                    four + five + six == 0 | seven + eight + nine == 0)
                {
                    winner = true;
                    finalWinner = "X";
                    printBoard();
                    Console.WriteLine("X Wins! Congratulations!");
                }
                else if (one + two + three == 3 | one + four + seven == 3 | one + five + nine == 3 |
                    two + five + eight == 3 | three + five + seven == 3 | three + six + nine == 3 |
                    four + five + six == 3 | seven + eight + nine == 3)
                {
                    winner = true;
                    finalWinner = "O";
                    printBoard();
                    Console.WriteLine("O Wins! Congratulations!");
                }
            }

            // Game set into the function to be called if game is wanting to be replayed.
            // Logic set to switch between active players and affect variables accordingly
            // until a winner can be decided from the checkWinner function.
            void runGame()
            {
                Console.WriteLine("Setting the board: \n");
                resetVariables();

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
                                    
                                    // Try/Catch is here because of exception errors when an
                                    // empty string is entered. Assigning anything that is an
                                    // error with 0 moves us to the default case in the switch,
                                    // so it will let them know their input was invalid and ask
                                    // for them to input another choice instead of crashing the program.
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
                                            if (one == 4)
                                            {
                                                TTTBoard[0, 0] = activeLetter;
                                                one = 0;
                                                activePlayer = 1;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 2:
                                            if (two == 4)
                                            {
                                                TTTBoard[0, 1] = activeLetter;
                                                two = 0;
                                                activePlayer = 1;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 3:
                                            if (three == 4)
                                            {
                                                TTTBoard[0, 2] = activeLetter;
                                                three = 0;
                                                activePlayer = 1;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 4:
                                            if (four == 4)
                                            {
                                                TTTBoard[1, 0] = activeLetter;
                                                four = 0;
                                                activePlayer = 1;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 5:
                                            if (five == 4)
                                            {
                                                TTTBoard[1, 1] = activeLetter;
                                                five = 0;
                                                activePlayer = 1;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 6:
                                            if (six == 4)
                                            {
                                                TTTBoard[1, 2] = activeLetter;
                                                six = 0;
                                                activePlayer = 1;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 7:
                                            if (seven == 4)
                                            {
                                                TTTBoard[2, 0] = activeLetter;
                                                seven = 0;
                                                activePlayer = 1;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 8:
                                            if (eight == 4)
                                            {
                                                TTTBoard[2, 1] = activeLetter;
                                                eight = 0;
                                                activePlayer = 1;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 9:
                                            if (nine == 4)
                                            {
                                                TTTBoard[2, 2] = activeLetter;
                                                nine = 0;
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
                                checkWinner();
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
                                            if (one == 4)
                                            {
                                                TTTBoard[0, 0] = activeLetter;
                                                one = 1;
                                                activePlayer = 0;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 2:
                                            if (two == 4)
                                            {
                                                TTTBoard[0, 1] = activeLetter;
                                                two = 1;
                                                activePlayer = 0;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 3:
                                            if (three == 4)
                                            {
                                                TTTBoard[0, 2] = activeLetter;
                                                three = 1;
                                                activePlayer = 0;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 4:
                                            if (four == 4)
                                            {
                                                TTTBoard[1, 0] = activeLetter;
                                                four = 1;
                                                activePlayer = 0;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 5:
                                            if (five == 4)
                                            {
                                                TTTBoard[1, 1] = activeLetter;
                                                five = 1;
                                                activePlayer = 0;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 6:
                                            if (six == 4)
                                            {
                                                TTTBoard[1, 2] = activeLetter;
                                                six = 1;
                                                activePlayer = 0;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 7:
                                            if (seven == 4)
                                            {
                                                TTTBoard[2, 0] = activeLetter;
                                                seven = 1;
                                                activePlayer = 0;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 8:
                                            if (eight == 4)
                                            {
                                                TTTBoard[2, 1] = activeLetter;
                                                eight = 1;
                                                activePlayer = 0;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("That spot is already taken. Please choose another.");
                                                break;
                                            }
                                        case 9:
                                            if (nine == 4)
                                            {
                                                TTTBoard[2, 2] = activeLetter;
                                                nine = 1;
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
                                checkWinner();
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                    if (!(one == 4 | two == 4 | three == 4 | four == 4 | five == 4 | six == 4
                            | seven == 4 | eight == 4 | nine == 4))
                    {
                        winner = true;
                    }
                }
            }

            // This function sets the pertinent variable back to the default values to allow
            // for a fresh game to be played after completing one.
            void resetVariables()
            {
                one = 4;
                two = 4;
                three = 4;
                four = 4;
                five = 4;
                six = 4;
                seven = 4;
                eight = 4;
                nine = 4;
                activePlayer = 0;
                finalWinner = "tie";

                TTTBoard[0, 0] = '1';
                TTTBoard[0, 1] = '2';
                TTTBoard[0, 2] = '3';
                TTTBoard[1, 0] = '4';
                TTTBoard[1, 1] = '5';
                TTTBoard[1, 2] = '6';
                TTTBoard[2, 0] = '7';
                TTTBoard[2, 1] = '8';
                TTTBoard[2, 2] = '9';

                winner = false;
            }

            // Where the game starts being called and played. Will continue until a game is completed
            // and the players enter "N" to end the program.
            while (playAgain == "y")
            {

                runGame();

                if (finalWinner == "tie")
                {
                    printBoard();
                    Console.WriteLine("Tie Game! Better luck next time!");
                }
                Console.WriteLine("Would you like to play again? (y/n): ");
                playAgain = Console.ReadLine().ToLower();
                while (playAgain != "y" & playAgain != "n")
                {
                    Console.WriteLine("Sorry I didn't understand that input. Please enter Y or N if you would like to play again: ");
                    playAgain = Console.ReadLine();
                }
            }

            Console.WriteLine("Thanks For Playing!");
        }
    }
}
