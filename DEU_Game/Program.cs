using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEU_Game
{
    class Program
    {
        protected void display(int x, int y, string s)
        {
            //I used the display command that we used in the previous group project to color the DEU text in this project.
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
        private static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            int[] A1 = new int[15];
            int[] A2 = new int[15];
            int[] A3 = new int[15];
            int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };

            string[] names = { "      Derya", "      Elife", "      Fatih", "      Ali", "      Azra", "      Sibel", "      Cem", "      Nazan", "      Mehmet", "      Nil", "      Can", "      Tarkan" };

            Random num = new Random();

            int number, random_array, count1, count2, index1, index2, index3, score1, score2, a, b, c, d, e, f, dx, dy, winner, g;

            winner = 0;
            a = -1;
            b = -1;
            c = -1;
            d = -1;
            e = -1;
            f = 1;
            g = 0;
            dx = 0;
            dy = 0;
            count1 = 0;
            count2 = 0;
            index1 = 0;
            index2 = 0;
            index3 = 0;
            score1 = 120;
            score2 = 120;

            Program p = new Program();

            while (count1 != 45)
            {
                //Firstly, lines and numbers randomly selected by the program.
                random_array = num.Next(1, 4);
                number = num.Next(1, 4);

                if (random_array == 1)
                {
                    if (index1 < 15)
                    {
                        A1[index1] = number;
                        count1++;
                        count2++;
                        index1++;
                    }
                    else
                    {
                        random_array = num.Next(2, 4);
                        number = num.Next(1, 4);
                    }
                }

                if (random_array == 2)
                {
                    if (index2 < 15)
                    {
                        A2[index2] = number;
                        count1++;
                        count2++;
                        index2++;
                    }
                    else
                    {
                        random_array = num.Next(1, 4);
                        if (random_array == 2)
                        {
                            while (random_array == 2)
                            {
                                random_array = num.Next(1, 4);
                            }
                        }
                        number = num.Next(1, 4);
                        if (random_array == 1)
                        {
                            count2++;
                        }
                    }
                }

                if (random_array == 3)
                {
                    if (index3 < 15)
                    {
                        A3[index3] = number;
                        count1++;
                        count2++;
                        index3++;
                    }
                    else
                    {
                        random_array = num.Next(1, 4);
                        if (random_array == 3)
                        {
                            while (random_array == 3)
                            {
                                random_array = num.Next(1, 4);
                            }
                        }
                        number = num.Next(1, 4);
                        count2++;
                    }
                }

                if (count1 == count2)
                {
                    //Selected numbers converted letters in arrays.
                    Console.Write(" Step: " + count1);
                    if (count1 % 2 == 0)
                    {
                        Console.Write("   Player2 Turn");
                    }
                    else
                    {
                        Console.Write("   Player1 Turn");
                    }
                    Console.WriteLine();

                    Console.Write(" ╔═════════════════════╗");
                    Console.WriteLine();

                    Console.Write(" ");
                    Console.Write("║");
                    Console.Write(" ");
                    Console.Write("A1");
                    Console.Write("-");
                    Console.Write(" ");
                    for (int i = 0; i < A1.Length; i++)
                    {
                        if (A1[i] > 0)
                        {
                            if (A1[i] == 1)
                            {
                                Console.Write("D");
                            }
                            else if (A1[i] == 2)
                            {
                                Console.Write("E");
                            }
                            else if (A1[i] == 3)
                            {
                                Console.Write("U");
                            }
                        }
                        else if (A1[i] == 0)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write(" ");
                    Console.Write("║");

                    //I used the if function to decrease the score with each step.
                    if (count1 % 2 != 0)
                    {
                        score1 = score1 - 5;
                    }
                    Console.Write(" Player1: " + score1);
                    Console.WriteLine();

                    Console.Write(" ");
                    Console.Write("║");
                    Console.Write(" ");
                    Console.Write("A2");
                    Console.Write("-");
                    Console.Write(" ");
                    for (int i = 0; i < A2.Length; i++)
                    {
                        if (A2[i] > 0)
                        {
                            if (A2[i] == 1)
                            {
                                Console.Write("D");
                            }
                            else if (A2[i] == 2)
                            {
                                Console.Write("E");
                            }
                            else if (A2[i] == 3)
                            {
                                Console.Write("U");
                            }
                        }
                        else if (A2[i] == 0)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write(" ");
                    Console.Write("║");
                    Console.WriteLine();

                    Console.Write(" ");
                    Console.Write("║");
                    Console.Write(" ");
                    Console.Write("A3");
                    Console.Write("-");
                    Console.Write(" ");
                    for (int i = 0; i < A3.Length; i++)
                    {
                        if (A3[i] > 0)
                        {
                            if (A3[i] == 1)
                            {
                                Console.Write("D");
                            }
                            else if (A3[i] == 2)
                            {
                                Console.Write("E");
                            }
                            else if (A3[i] == 3)
                            {
                                Console.Write("U");
                            }
                        }
                        else if (A3[i] == 0)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write(" ");
                    Console.Write("║");
                    if (count1 % 2 == 0)
                    {
                        score2 = score2 - 5;
                    }
                    Console.Write(" Player2: " + score2);
                    Console.WriteLine();

                    Console.Write(" ╚═════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(750); //I used this command to make the text appear a little slow on the screen.
                }
                else
                {
                    count2 = count2 - 1;
                }
                //In this section, I wrote the probability of winning the game with different variables.
                if (f == 1)
                {
                    for (int i = 0; i < A1.Length; i++)
                    {
                        if (i > 1)
                        {
                            a = i - 2;
                            b = i - 1;
                            if (A1[a] == 1)
                            {
                                if (A1[b] == 2)
                                {
                                    if (A1[i] == 3)
                                    {
                                        if (count1 % 2 == 0)
                                        {
                                            Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                            count1 = 45; //It is used to exit the while loop.
                                            f = 0;
                                            winner = 2; //The winning player is thrown into the variable and used on the scoreboard.

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;

                                            //The part that writes DEU in the table is colored by the program.
                                            dx = a + 7;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "D");

                                            dx = a + 8;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "U");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 1;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = a + 7;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "D");

                                            dx = a + 8;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "U");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (f == 1)
                {
                    for (int i = 0; i < A2.Length; i++)
                    {
                        if (i > 1)
                        {
                            a = i - 2;
                            b = i - 1;
                            if (A2[a] == 1)
                            {
                                if (A2[b] == 2)
                                {
                                    if (A2[i] == 3)
                                    {
                                        if (count1 % 2 == 0)
                                        {
                                            Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                            count1 = 45;
                                            f = 0; //This variable prevents reevaluation if the game is won in the above probabilities.
                                            winner = 2;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = a + 7;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "D");

                                            dx = a + 8;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "U");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 1;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = a + 7;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "D");

                                            dx = a + 8;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "U");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (f == 1)
                {
                    for (int i = 0; i < A3.Length; i++)
                    {
                        if (i > 1)
                        {
                            a = i - 2;
                            b = i - 1;
                            if (A3[a] == 1)
                            {
                                if (A3[b] == 2)
                                {
                                    if (A3[i] == 3)
                                    {
                                        if (count1 % 2 == 0)
                                        {
                                            Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 2;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = a + 7;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "D");

                                            dx = a + 8;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "U");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 1;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = a + 7;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "D");

                                            dx = a + 8;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "U");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (f == 1)
                {
                    for (int i = 0; i < A1.Length; i++)
                    {
                        if (i > 1)
                        {
                            a = i - 2;
                            b = i - 1;
                            if (A1[a] == 3)
                            {
                                if (A1[b] == 2)
                                {
                                    if (A1[i] == 1)
                                    {
                                        if (count1 % 2 == 0)
                                        {
                                            Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 2;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = a + 7;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "U");

                                            dx = a + 8;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "D");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 1;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = a + 7;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "U");

                                            dx = a + 8;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "D");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (f == 1)
                {
                    for (int i = 0; i < A2.Length; i++)
                    {
                        if (i > 1)
                        {
                            a = i - 2;
                            b = i - 1;
                            if (A2[a] == 3)
                            {
                                if (A2[b] == 2)
                                {
                                    if (A2[i] == 1)
                                    {
                                        if (count1 % 2 == 0)
                                        {
                                            Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 2;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = a + 7;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "U");

                                            dx = a + 8;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "D");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 1;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = a + 7;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "U");

                                            dx = a + 8;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "D");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (f == 1)
                {
                    for (int i = 0; i < A3.Length; i++)
                    {
                        if (i > 1)
                        {
                            a = i - 2;
                            b = i - 1;
                            if (A3[a] == 3)
                            {
                                if (A3[b] == 2)
                                {
                                    if (A3[i] == 1)
                                    {
                                        if (count1 % 2 == 0)
                                        {
                                            Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 2;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = a + 7;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "U");

                                            dx = a + 8;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "D");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 1;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = a + 7;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "U");

                                            dx = a + 8;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "E");

                                            dx = a + 9;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "D");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (f == 1)
                {
                    for (int i = 0; i < A1.Length; i++)
                    {
                        c = i;
                        if (A1[i] == 1)
                        {
                            if (A2[c] == 2)
                            {
                                if (A3[c] == 3)
                                {
                                    if (count1 % 2 == 0)
                                    {
                                        Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                        count1 = 45;
                                        f = 0;
                                        winner = 2;

                                        Console.ResetColor();
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        dx = c + 7;
                                        dy = (7 * count2) - 5;
                                        p.display(dx, dy, "D");

                                        dx = c + 7;
                                        dy = (7 * count2) - 4;
                                        p.display(dx, dy, "E");

                                        dx = c + 7;
                                        dy = (7 * count2) - 3;
                                        p.display(dx, dy, "U");

                                        Console.ResetColor();

                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        break;

                                    }
                                    else
                                    {
                                        Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                        count1 = 45;
                                        f = 0;
                                        winner = 1;

                                        Console.ResetColor();
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        dx = c + 7;
                                        dy = (7 * count2) - 5;
                                        p.display(dx, dy, "D");

                                        dx = c + 7;
                                        dy = (7 * count2) - 4;
                                        p.display(dx, dy, "E");

                                        dx = c + 7;
                                        dy = (7 * count2) - 3;
                                        p.display(dx, dy, "U");

                                        Console.ResetColor();

                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (f == 1)
                {
                    for (int i = 0; i < A1.Length; i++)
                    {
                        c = i;
                        if (A1[i] == 3)
                        {
                            if (A2[c] == 2)
                            {
                                if (A3[c] == 1)
                                {
                                    if (count1 % 2 == 0)
                                    {
                                        Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                        count1 = 45;
                                        f = 0;
                                        winner = 2;

                                        Console.ResetColor();
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        dx = c + 7;
                                        dy = (7 * count2) - 5;
                                        p.display(dx, dy, "U");

                                        dx = c + 7;
                                        dy = (7 * count2) - 4;
                                        p.display(dx, dy, "E");

                                        dx = c + 7;
                                        dy = (7 * count2) - 3;
                                        p.display(dx, dy, "D");

                                        Console.ResetColor();

                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        break;

                                    }
                                    else
                                    {
                                        Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                        count1 = 45;
                                        f = 0;
                                        winner = 1;

                                        Console.ResetColor();
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        dx = c + 7;
                                        dy = (7 * count2) - 5;
                                        p.display(dx, dy, "U");

                                        dx = c + 7;
                                        dy = (7 * count2) - 4;
                                        p.display(dx, dy, "E");

                                        dx = c + 7;
                                        dy = (7 * count2) - 3;
                                        p.display(dx, dy, "D");

                                        Console.ResetColor();

                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (f == 1)
                {
                    for (int i = 0; i < A1.Length; i++)
                    {
                        a = i - 2;
                        b = i - 1;
                        c = i;
                        d = i + 1;
                        e = i + 2;
                        if (d > 14)
                        {
                            break;
                        }
                        if (e > 14)
                        {
                            break;
                        }
                        if (A1[i] == 1)
                        {
                            if (A2[d] == 2)
                            {
                                if (A3[e] == 3)
                                {
                                    if (count1 % 2 == 0)
                                    {
                                        Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                        count1 = 45;
                                        f = 0;
                                        winner = 2;

                                        Console.ResetColor();
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        dx = c + 7;
                                        dy = (7 * count2) - 5;
                                        p.display(dx, dy, "D");

                                        dx = c + 8;
                                        dy = (7 * count2) - 4;
                                        p.display(dx, dy, "E");

                                        dx = c + 9;
                                        dy = (7 * count2) - 3;
                                        p.display(dx, dy, "U");

                                        Console.ResetColor();

                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        break;

                                    }
                                    else
                                    {
                                        Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                        count1 = 45;
                                        f = 0;
                                        winner = 1;

                                        Console.ResetColor();
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        dx = c + 7;
                                        dy = (7 * count2) - 5;
                                        p.display(dx, dy, "D");

                                        dx = c + 8;
                                        dy = (7 * count2) - 4;
                                        p.display(dx, dy, "E");

                                        dx = c + 9;
                                        dy = (7 * count2) - 3;
                                        p.display(dx, dy, "U");

                                        Console.ResetColor();

                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (f == 1)
                {
                    for (int i = 0; i < A1.Length; i++)
                    {
                        if (i > 1)
                        {
                            a = i - 2;
                            b = i - 1;
                            c = i;
                            d = i + 1;
                            e = i + 2;
                            if (A1[i] == 1)
                            {
                                if (A2[b] == 2)
                                {
                                    if (A3[a] == 3)
                                    {
                                        if (count1 % 2 == 0)
                                        {
                                            Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 2;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = c + 7;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "D");

                                            dx = c + 6;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "E");

                                            dx = c + 5;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "U");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 1;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = c + 7;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "D");

                                            dx = c + 6;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "E");

                                            dx = c + 5;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "U");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (f == 1)
                {
                    for (int i = 0; i < A1.Length; i++)
                    {
                        a = i - 2;
                        b = i - 1;
                        c = i;
                        d = i + 1;
                        e = i + 2;
                        if (d > 14)
                        {
                            break;
                        }
                        if (e > 14)
                        {
                            break;
                        }
                        if (A1[i] == 3)
                        {
                            if (A2[d] == 2)
                            {
                                if (A3[e] == 1)
                                {
                                    if (count1 % 2 == 0)
                                    {
                                        Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                        count1 = 45;
                                        f = 0;
                                        winner = 2;

                                        Console.ResetColor();
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        dx = c + 7;
                                        dy = (7 * count2) - 5;
                                        p.display(dx, dy, "U");

                                        dx = c + 8;
                                        dy = (7 * count2) - 4;
                                        p.display(dx, dy, "E");

                                        dx = c + 9;
                                        dy = (7 * count2) - 3;
                                        p.display(dx, dy, "D");

                                        Console.ResetColor();

                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        break;

                                    }
                                    else
                                    {
                                        Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                        count1 = 45;
                                        f = 0;
                                        winner = 1;

                                        Console.ResetColor();
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        dx = c + 7;
                                        dy = (7 * count2) - 5;
                                        p.display(dx, dy, "U");

                                        dx = c + 8;
                                        dy = (7 * count2) - 4;
                                        p.display(dx, dy, "E");

                                        dx = c + 9;
                                        dy = (7 * count2) - 3;
                                        p.display(dx, dy, "D");

                                        Console.ResetColor();

                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (f == 1)
                {
                    for (int i = 0; i < A1.Length; i++)
                    {
                        if (i > 1)
                        {
                            a = i - 2;
                            b = i - 1;
                            c = i;
                            d = i + 1;
                            e = i + 2;
                            if (A1[i] == 3)
                            {
                                if (A2[b] == 2)
                                {
                                    if (A3[a] == 1)
                                    {
                                        if (count1 % 2 == 0)
                                        {
                                            Console.WriteLine(" Player2 won! Player2 got " + score2 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 2;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = c + 7;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "U");

                                            dx = c + 6;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "E");

                                            dx = c + 5;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "D");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(" Player1 won! Player1 got " + score1 + " points.");
                                            count1 = 45;
                                            f = 0;
                                            winner = 1;

                                            Console.ResetColor();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            dx = c + 7;
                                            dy = (7 * count2) - 5;
                                            p.display(dx, dy, "U");

                                            dx = c + 6;
                                            dy = (7 * count2) - 4;
                                            p.display(dx, dy, "E");

                                            dx = c + 5;
                                            dy = (7 * count2) - 3;
                                            p.display(dx, dy, "D");

                                            Console.ResetColor();

                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (f == 1)
                {
                    if (count1 == 45)
                    {
                        Console.WriteLine(" Tie!");
                        Console.WriteLine();
                        Console.WriteLine(" Since players could not win the game, their points were reset.");
                        Console.WriteLine();
                        Console.WriteLine(" Player1 and player2 got 0 point.");
                        Console.WriteLine();
                        f = 0;
                        winner = 3;
                        score1 = 0;
                        score2 = 0;
                    }
                }
            }

            Console.WriteLine(" Please wait...");
            Console.WriteLine(" Highscore table is loading in 4 seconds.");
            Console.WriteLine();

            System.Threading.Thread.Sleep(4000);

            Console.WriteLine(" ═══ Higscore Table ═══");
            Console.WriteLine();


            for (int i = 0; i < scores.Length; i++)
            {
                if (winner == 1)
                {
                    if (score1 < scores[i])
                    {
                        Console.WriteLine(names[i] + ": " + scores[i]);
                        Console.WriteLine();

                        if (i == 11)
                        {
                            Console.WriteLine("      Player1: " + score1);
                            Console.WriteLine();
                        }
                    }
                    else if (score1 == scores[i])
                    {
                        Console.WriteLine(names[i] + ": " + scores[i]);
                        Console.WriteLine();
                        i = i + 1;
                        if (score1 == scores[i])
                        {
                            Console.WriteLine(names[i] + ": " + scores[i]);
                            Console.WriteLine();
                            i = i + 1;
                            if (i < 12)
                            {
                                if (score1 == scores[i])
                                {
                                    Console.WriteLine(names[i] + ": " + scores[i]);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    i = i - 1;
                                }
                            }
                        }
                        else
                        {
                            i = i - 1;
                        }
                    }
                    else if (score1 > scores[i])
                    {
                        Console.WriteLine("      Player1: " + score1);
                        Console.WriteLine();
                        g = i;

                        for (int j = g; i < scores.Length; i++)
                        {
                            Console.WriteLine(names[i] + ": " + scores[i]);
                            Console.WriteLine();
                        }
                        i = 12;
                    }
                }
                else if (winner == 2)
                {
                    if (score2 < scores[i])
                    {
                        Console.WriteLine(names[i] + ": " + scores[i]);
                        Console.WriteLine();
                        if (i == 11)
                        {
                            Console.WriteLine("      Player2: " + score2);
                            Console.WriteLine();
                        }
                    }
                    else if (score2 == scores[i])
                    {
                        Console.WriteLine(names[i] + ": " + scores[i]);
                        Console.WriteLine();
                        i = i + 1;
                        if (score2 == scores[i])
                        {
                            Console.WriteLine(names[i] + ": " + scores[i]);
                            Console.WriteLine();
                            i = i + 1;

                            if (i < 12)
                            {
                                if (score2 == scores[i])
                                {
                                    Console.WriteLine(names[i] + ": " + scores[i]);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    i = i - 1;
                                }
                            }
                        }
                        else
                        {
                            i = i - 1;
                        }
                    }

                    else if (score2 > scores[i])
                    {
                        Console.WriteLine("      Player2: " + score2);
                        Console.WriteLine();
                        g = i;

                        for (int j = g; i < scores.Length; i++)
                        {
                            Console.WriteLine(names[i] + ": " + scores[i]);
                            Console.WriteLine();
                        }
                        i = 12;
                    }
                }
                else if (winner == 3)
                {
                    Console.WriteLine(names[i] + ": " + scores[i]);
                    Console.WriteLine();

                    if (i == 11)
                    {
                        Console.WriteLine("      Player1: " + score1);
                        Console.WriteLine();
                        Console.WriteLine("      Player2: " + score2);
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine(" You can scroll up and review each step. Thanks for playing.");

            Console.ReadKey();

        }
    }
}

