﻿// Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
    //The card faces should start from 2 to A.
    //Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        char clubs = '\u2663';
        char diamonds = '\u2666';
        char hearts = '\u2665';
        char spades = '\u2660';

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {

                    case 2:
                        Console.Write("2"); break;
                    case 3:
                        Console.Write("3"); break;
                    case 4:
                        Console.Write("4"); break;
                    case 5:
                        Console.Write("5"); break;
                    case 6:
                        Console.Write("6"); break;
                    case 7:
                        Console.Write("7"); break;
                    case 8:
                        Console.Write("8"); break;
                    case 9:
                        Console.Write("9"); break;
                    case 10:
                        Console.Write("10"); break;
                    case 11:
                        Console.Write("J"); break;
                    case 12:
                        Console.Write("D"); break;
                    case 13:
                        Console.Write("K"); break;
                    case 14:
                        Console.Write("A"); break;
                    default:
                        Console.Write("Error!");
                        break;
                }
                switch (j)
                {
                    case 1:
                        if (i == 10)
                        {
                            Console.Write("{0, -2} ", spades); break;
                        }
                        else
                        {
                            Console.Write("{0, -3} ", spades); break;
                        }
                    case 2:
                        if (i == 10)
                        {
                            Console.Write("{0, -2} ", clubs); break;
                        }
                        else
                        {
                            Console.Write("{0, -3} ", clubs); break;
                        }
                    case 3:
                        if (i == 10)
                        {
                            Console.Write("{0, -2} ", hearts); break;
                        }
                        else
                        {
                            Console.Write("{0, -3} ", hearts); break;
                        }
                    case 4:
                        if (i == 10)
                        {
                            Console.Write("{0, -2} ", diamonds); break;
                        }
                        else
                        {
                            Console.Write("{0, -3} ", diamonds); break;
                        }
                    default:
                        Console.Write("Error!");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
