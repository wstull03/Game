using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string playAgain = "yes";

            do
            {

                char playerSymbol = '?';
                char computerSymbol = '?';
                int userChoice = 0;
                int computerChoice = 0;
                Random number = new Random();

                do
                {

                    Console.WriteLine("Player...X's or O's ?");
                    playerSymbol = char.Parse(Console.ReadLine().ToUpper());

                    switch (playerSymbol)
                    {
                        case 'X':
                            computerSymbol = 'O';
                            break;

                        case 'O':
                            computerSymbol = 'X';
                            break;

                        default:
                            break;
                    }
                }
                while (playerSymbol != 'X' && playerSymbol != 'O');

                //if (playerSymbol == 'X')
                //{
                //    computerSymbol = 'O';
                //}
                //else if (playerSymbol == 'O')
                //{
                //    computerSymbol = 'X';
                //}

                Console.WriteLine("Player = " + playerSymbol);
                Console.WriteLine("Computer = " + computerSymbol);
                Console.WriteLine();
                Console.Clear();

                char row1_column1 = '1';
                char row1_column3 = '2';
                char row1_column5 = '3';

                char row3_column1 = '4';
                char row3_column3 = '5';
                char row3_column5 = '6';

                char row5_column1 = '7';
                char row5_column3 = '8';
                char row5_column5 = '9';

                Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                Console.WriteLine("-" + "-" + "-" + "-" + "-");
                Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                Console.WriteLine("-" + "-" + "-" + "-" + "-");
                Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                Console.WriteLine();

                List<int> availableSpaces = new List<int>();
                availableSpaces.Add(1);
                availableSpaces.Add(2);
                availableSpaces.Add(3);
                availableSpaces.Add(4);
                availableSpaces.Add(5);
                availableSpaces.Add(6);
                availableSpaces.Add(7);
                availableSpaces.Add(8);
                availableSpaces.Add(9);

                List<string> utilized_Spaces = new List<string>();

                int counter = 0;

                do
                {
                    if (row1_column1 == playerSymbol && row1_column3 == playerSymbol && row1_column5 == playerSymbol) { counter = 9; }
                    else if (row3_column1 == playerSymbol && row3_column3 == playerSymbol && row3_column5 == playerSymbol) { counter = 9; }
                    else if (row5_column1 == playerSymbol && row5_column3 == playerSymbol && row5_column5 == playerSymbol) { counter = 9; }
                    else if (row1_column1 == playerSymbol && row3_column1 == playerSymbol && row5_column1 == playerSymbol) { counter = 9; }
                    else if (row1_column3 == playerSymbol && row3_column3 == playerSymbol && row5_column3 == playerSymbol) { counter = 9; }
                    else if (row1_column5 == playerSymbol && row3_column5 == playerSymbol && row5_column5 == playerSymbol) { counter = 9; }
                    else if (row1_column1 == playerSymbol && row3_column3 == playerSymbol && row5_column5 == playerSymbol) { counter = 9; }
                    else if (row1_column5 == playerSymbol && row3_column3 == playerSymbol && row5_column1 == playerSymbol) { counter = 9; }

                    else if (row1_column1 == computerSymbol && row1_column3 == computerSymbol && row1_column5 == computerSymbol) { counter = 9; }
                    else if (row3_column1 == computerSymbol && row3_column3 == computerSymbol && row3_column5 == computerSymbol) { counter = 9; }
                    else if (row5_column1 == computerSymbol && row5_column3 == computerSymbol && row5_column5 == computerSymbol) { counter = 9; }
                    else if (row1_column1 == computerSymbol && row3_column1 == computerSymbol && row5_column1 == computerSymbol) { counter = 9; }
                    else if (row1_column3 == computerSymbol && row3_column3 == computerSymbol && row5_column3 == computerSymbol) { counter = 9; }
                    else if (row1_column5 == computerSymbol && row3_column5 == computerSymbol && row5_column5 == computerSymbol) { counter = 9; }
                    else if (row1_column1 == computerSymbol && row3_column3 == computerSymbol && row5_column5 == computerSymbol) { counter = 9; }
                    else if (row1_column5 == computerSymbol && row3_column3 == computerSymbol && row5_column1 == computerSymbol) { counter = 9; }

                    else
                    {

                        Console.WriteLine("Next Move:");
                        int.TryParse(Console.ReadLine(), out userChoice);
                        Console.WriteLine();

                        if (availableSpaces.Contains(userChoice))
                        {

                            switch (userChoice)
                            {

                                case 1:
                                    row1_column1 = playerSymbol;
                                    Console.Clear();
                                    Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                    Console.WriteLine();
                                    counter++;
                                    break;

                                case 2:
                                    row1_column3 = playerSymbol;
                                    Console.Clear();
                                    Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                    Console.WriteLine();
                                    counter++;
                                    break;

                                case 3:
                                    row1_column5 = playerSymbol;
                                    Console.Clear();
                                    Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                    Console.WriteLine();
                                    counter++;
                                    break;

                                case 4:
                                    row3_column1 = playerSymbol;
                                    Console.Clear();
                                    Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                    Console.WriteLine();
                                    counter++;
                                    break;

                                case 5:
                                    row3_column3 = playerSymbol;
                                    Console.Clear();
                                    Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                    Console.WriteLine();
                                    counter++;
                                    break;

                                case 6:
                                    row3_column5 = playerSymbol;
                                    Console.Clear();
                                    Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                    Console.WriteLine();
                                    counter++;
                                    break;

                                case 7:
                                    row5_column1 = playerSymbol;
                                    Console.Clear();
                                    Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                    Console.WriteLine();
                                    counter++;
                                    break;

                                case 8:
                                    row5_column3 = playerSymbol;
                                    Console.Clear();
                                    Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                    Console.WriteLine();
                                    counter++;
                                    break;

                                case 9:
                                    row5_column5 = playerSymbol;
                                    Console.Clear();
                                    Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                    Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                    Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                    Console.WriteLine();
                                    counter++;
                                    break;

                                default:
                                    break;
                            }

                            availableSpaces.Remove(userChoice);

                            for (int i = 0; i < availableSpaces.Count; i++)
                            {
                                //Console.Write(availableSpaces[i]);
                            }
                            Console.WriteLine();
                            Console.WriteLine();

                            if (row1_column1 == playerSymbol && row1_column3 == playerSymbol && row1_column5 == playerSymbol) { availableSpaces.Clear(); }
                            else if (row3_column1 == playerSymbol && row3_column3 == playerSymbol && row3_column5 == playerSymbol) { availableSpaces.Clear(); }
                            else if (row5_column1 == playerSymbol && row5_column3 == playerSymbol && row5_column5 == playerSymbol) { availableSpaces.Clear(); }
                            else if (row1_column1 == playerSymbol && row3_column1 == playerSymbol && row5_column1 == playerSymbol) { availableSpaces.Clear(); }
                            else if (row1_column3 == playerSymbol && row3_column3 == playerSymbol && row5_column3 == playerSymbol) { availableSpaces.Clear(); }
                            else if (row1_column5 == playerSymbol && row3_column5 == playerSymbol && row5_column5 == playerSymbol) { availableSpaces.Clear(); }
                            else if (row1_column1 == playerSymbol && row3_column3 == playerSymbol && row5_column5 == playerSymbol) { availableSpaces.Clear(); }
                            else if (row1_column5 == playerSymbol && row3_column3 == playerSymbol && row5_column1 == playerSymbol) { availableSpaces.Clear(); }

                            else if (row1_column1 == computerSymbol && row1_column3 == computerSymbol && row1_column5 == computerSymbol) { availableSpaces.Clear(); }
                            else if (row3_column1 == computerSymbol && row3_column3 == computerSymbol && row3_column5 == computerSymbol) { availableSpaces.Clear(); }
                            else if (row5_column1 == computerSymbol && row5_column3 == computerSymbol && row5_column5 == computerSymbol) { availableSpaces.Clear(); }
                            else if (row1_column1 == computerSymbol && row3_column1 == computerSymbol && row5_column1 == computerSymbol) { availableSpaces.Clear(); }
                            else if (row1_column3 == computerSymbol && row3_column3 == computerSymbol && row5_column3 == computerSymbol) { availableSpaces.Clear(); }
                            else if (row1_column5 == computerSymbol && row3_column5 == computerSymbol && row5_column5 == computerSymbol) { availableSpaces.Clear(); }
                            else if (row1_column1 == computerSymbol && row3_column3 == computerSymbol && row5_column5 == computerSymbol) { availableSpaces.Clear(); }
                            else if (row1_column5 == computerSymbol && row3_column3 == computerSymbol && row5_column1 == computerSymbol) { availableSpaces.Clear(); }

                            if (availableSpaces.Count != 0)
                            {
                                computerChoice = availableSpaces[number.Next(availableSpaces.Count)];

                                //Console.WriteLine("Next Move:");
                                //int.TryParse(Console.ReadLine(), out computerChoice);
                                //Console.WriteLine();

                                Console.WriteLine("computerChoice =" + computerChoice);
                                Console.WriteLine();

                                switch (computerChoice)
                                {

                                    case 1:
                                        row1_column1 = computerSymbol;
                                        Console.Clear();
                                        Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                        Console.WriteLine();
                                        counter++;
                                        break;

                                    case 2:
                                        row1_column3 = computerSymbol;
                                        Console.Clear();
                                        Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                        Console.WriteLine();
                                        counter++;
                                        break;

                                    case 3:
                                        row1_column5 = computerSymbol;
                                        Console.Clear();
                                        Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                        Console.WriteLine();
                                        counter++;
                                        break;

                                    case 4:
                                        row3_column1 = computerSymbol;
                                        Console.Clear();
                                        Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                        Console.WriteLine();
                                        counter++;
                                        break;

                                    case 5:
                                        row3_column3 = computerSymbol;
                                        Console.Clear();
                                        Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                        Console.WriteLine();
                                        counter++;
                                        break;

                                    case 6:
                                        row3_column5 = computerSymbol;
                                        Console.Clear();
                                        Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                        Console.WriteLine();
                                        counter++;
                                        break;

                                    case 7:
                                        row5_column1 = computerSymbol;
                                        Console.Clear();
                                        Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                        Console.WriteLine();
                                        counter++;
                                        break;

                                    case 8:
                                        row5_column3 = computerSymbol;
                                        Console.Clear();
                                        Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                        Console.WriteLine();
                                        counter++;
                                        break;

                                    case 9:
                                        row5_column5 = computerSymbol;
                                        Console.Clear();
                                        Console.WriteLine(row1_column1 + "|" + row1_column3 + "|" + row1_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row3_column1 + "|" + row3_column3 + "|" + row3_column5);
                                        Console.WriteLine("-" + "-" + "-" + "-" + "-");
                                        Console.WriteLine(row5_column1 + "|" + row5_column3 + "|" + row5_column5);
                                        Console.WriteLine();
                                        counter++;
                                        break;

                                    default:
                                        break;
                                }

                                availableSpaces.Remove(computerChoice);

                                for (int i = 0; i < availableSpaces.Count; i++)
                                {
                                    //Console.Write(availableSpaces[i]);
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                        }
                    }





                }
                while (counter != 9);

                if (row1_column1 == playerSymbol && row1_column3 == playerSymbol && row1_column5 == playerSymbol) { Console.WriteLine("Congratulations... You Win!"); }
                else if (row3_column1 == playerSymbol && row3_column3 == playerSymbol && row3_column5 == playerSymbol) { Console.WriteLine("Congratulations... You Win!"); }
                else if (row5_column1 == playerSymbol && row5_column3 == playerSymbol && row5_column5 == playerSymbol) { Console.WriteLine("Congratulations... You Win!"); }
                else if (row1_column1 == playerSymbol && row3_column1 == playerSymbol && row5_column1 == playerSymbol) { Console.WriteLine("Congratulations... You Win!"); }
                else if (row1_column3 == playerSymbol && row3_column3 == playerSymbol && row5_column3 == playerSymbol) { Console.WriteLine("Congratulations... You Win!"); }
                else if (row1_column5 == playerSymbol && row3_column5 == playerSymbol && row5_column5 == playerSymbol) { Console.WriteLine("Congratulations... You Win!"); }
                else if (row1_column1 == playerSymbol && row3_column3 == playerSymbol && row5_column5 == playerSymbol) { Console.WriteLine("Congratulations... You Win!"); }
                else if (row1_column5 == playerSymbol && row3_column3 == playerSymbol && row5_column1 == playerSymbol) { Console.WriteLine("Congratulations... You Win!"); }

                else if (row1_column1 == computerSymbol && row1_column3 == computerSymbol && row1_column5 == computerSymbol) { Console.WriteLine("Sorry... You Lose."); }
                else if (row3_column1 == computerSymbol && row3_column3 == computerSymbol && row3_column5 == computerSymbol) { Console.WriteLine("Sorry... You Lose."); }
                else if (row5_column1 == computerSymbol && row5_column3 == computerSymbol && row5_column5 == computerSymbol) { Console.WriteLine("Sorry... You Lose."); }
                else if (row1_column1 == computerSymbol && row3_column1 == computerSymbol && row5_column1 == computerSymbol) { Console.WriteLine("Sorry... You Lose."); }
                else if (row1_column3 == computerSymbol && row3_column3 == computerSymbol && row5_column3 == computerSymbol) { Console.WriteLine("Sorry... You Lose."); }
                else if (row1_column5 == computerSymbol && row3_column5 == computerSymbol && row5_column5 == computerSymbol) { Console.WriteLine("Sorry... You Lose."); }
                else if (row1_column1 == computerSymbol && row3_column3 == computerSymbol && row5_column5 == computerSymbol) { Console.WriteLine("Sorry... You Lose."); }
                else if (row1_column5 == computerSymbol && row3_column3 == computerSymbol && row5_column1 == computerSymbol) { Console.WriteLine("Sorry... You Lose."); }
                else { Console.WriteLine("Cat's Game"); }

                Console.WriteLine("Play Again? (yes or no)");
                playAgain = Console.ReadLine();

            } while (playAgain.ToUpper() != "NO");

            Console.WriteLine();

        }   
    }
}
