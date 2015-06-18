using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

struct Object
{
    public int x;
    public int y;
    public string c;
    public ConsoleColor color;
}

class FallingRocksGame
{


    static void printStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main()
    {

        int playFieldWidth = 60;
        int livesCount = 5;
        string[] rocksSymbols = { "^", "@", "*", "+++", "+", "+", "&", ";", "%", "$", "#", "!", ".." };
        int indexRocksSymbols;
        double speed = 100.0;
        Console.BufferHeight = Console.WindowHeight = 25;
        Console.BufferWidth = Console.WindowWidth = 60;
        Object user = new Object();
        user.x = 2;
        user.y = Console.WindowHeight - 1;
        user.c = "(0)";
        user.color = ConsoleColor.Yellow;

        Random randomGenerator = new Random();
        List<Object> objects = new List<Object>();
        string[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));

        while (true)
        {
            bool hitted = false;
            {
                indexRocksSymbols = randomGenerator.Next(0, rocksSymbols.Length);
                ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorNames[randomGenerator.Next(0, colorNames.Length)]);

                Object newObject = new Object();
                newObject.color = color;
                newObject.x = randomGenerator.Next(0, playFieldWidth);
                newObject.y = 5;
                newObject.c = rocksSymbols[indexRocksSymbols];
                objects.Add(newObject);
            }
            //Move rocks
            List<Object> newList = new List<Object>();

            for (int i = 0; i < objects.Count; i++)
            {
                Object oldObject = objects[i];
                Object newObject = new Object();
                newObject.x = oldObject.x;
                newObject.y = oldObject.y + 1;
                newObject.c = oldObject.c;
                newObject.color = oldObject.color;

                if ((newObject.c != "*" && newObject.y == user.y && newObject.x == user.x)
                            || (newObject.y == user.y && newObject.x == user.x + 1)
                            || (newObject.y == user.y && newObject.x == user.x + 2))
                {
                    livesCount--;
                    hitted = true;
                    if (livesCount <= 0)
                    {
                        printStringOnPosition(3, 3, "GAME OVER!!!", ConsoleColor.Red);
                        printStringOnPosition(25, 3, "Pres [enter] to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if (newObject.y < Console.WindowHeight)
                {
                    newList.Add(newObject);
                }
            }
            objects = newList;

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (user.x - 1 >= 0)
                    {
                        user.x = user.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (user.x + 1 < playFieldWidth)
                    {
                        user.x = user.x + 1;
                    }
                }
            }

            //Clear the console
            Console.Clear();

            //Redraw playfield
            if (hitted)
            {
                objects.Clear();
                printStringOnPosition(user.x, user.y, "XXX", ConsoleColor.Red);
            }
            else
            {
                printStringOnPosition(user.x, user.y, user.c, user.color);
            }
            foreach (Object rocks in objects)
            {
                printStringOnPosition(rocks.x, rocks.y, rocks.c, rocks.color);
            }

            //Draw info
            printStringOnPosition(3, 1, "*FALLING ROCKS*", ConsoleColor.Yellow);
            printStringOnPosition(28, 1, "Lives: " + livesCount, ConsoleColor.White);
            printStringOnPosition(40, 1, "Speed: " + speed, ConsoleColor.White);

            //Slow down the program
            Thread.Sleep(150);
        }
    }
}
