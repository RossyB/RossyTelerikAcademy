namespace GameMine
{
    using System;
    using System.Collections.Generic;

    public class Mine
    {
        public static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] field = CreatePlayingField();
            char[,] mines = PlaceTheMines();
            int count = 0;
            bool isMineClicked = false;
            List<PlayerScores> playerList = new List<PlayerScores>(6);
            int row = 0;
            int col = 0;
            bool isStartingNewGame = true;
            const int MaxCells = 35;
            bool isOpenMaxCells = false;

            do
            {
                if (isStartingNewGame)
                {
                    Console.WriteLine("Start playing \"Minesweeper\". Try to find fields without mines." +
                " Commands:\n -'top' shows rating;\n -'restart' start new game;\n -'exit' close program!");
                    UpdatePlayingField(field);
                    isStartingNewGame = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Raiting(playerList);
                        break;
                    case "restart":
                        field = CreatePlayingField();
                        mines = PlaceTheMines();
                        UpdatePlayingField(field);
                        isMineClicked = false;
                        isStartingNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye! Bye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                TurnOn(field, mines, row, col);
                                count++;
                            }

                            if (MaxCells == count)
                            {
                                isOpenMaxCells = true;
                            }
                            else
                            {
                                UpdatePlayingField(field);
                            }
                        }
                        else
                        {
                            isMineClicked = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! invalid command\n");
                        break;
                }

                if (isMineClicked)
                {
                    UpdatePlayingField(mines);
                    Console.Write("\nGame over with {0} scores. Enter your nickname: ", count);
                    string nickname = Console.ReadLine();
                    PlayerScores t = new PlayerScores(nickname, count);
                    if (playerList.Count < 5)
                    {
                        playerList.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < playerList.Count; i++)
                        {
                            if (playerList[i].Scores < t.Scores)
                            {
                                playerList.Insert(i, t);
                                playerList.RemoveAt(playerList.Count - 1);
                                break;
                            }
                        }
                    }

                    playerList.Sort((PlayerScores r1, PlayerScores r2) => r2.Name.CompareTo(r1.Name));
                    playerList.Sort((PlayerScores r1, PlayerScores r2) => r2.Scores.CompareTo(r1.Scores));
                    Raiting(playerList);

                    field = CreatePlayingField();
                    mines = PlaceTheMines();
                    count = 0;
                    isMineClicked = false;
                    isStartingNewGame = true;
                }

                if (isOpenMaxCells)
                {
                    Console.WriteLine("\nCongratulations! You open 35 cells and win.");
                    UpdatePlayingField(mines);
                    Console.WriteLine("Enter your nickname: ");
                    string name = Console.ReadLine();
                    PlayerScores scores = new PlayerScores(name, count);
                    playerList.Add(scores);
                    Raiting(playerList);
                    field = CreatePlayingField();
                    mines = PlaceTheMines();
                    count = 0;
                    isOpenMaxCells = false;
                    isStartingNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria");
            Console.Read();
        }

        private static void Raiting(List<PlayerScores> scores)
        {
            Console.WriteLine("\nScores:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, scores[i].Name, scores[i].Scores);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty rating!\n");
            }
        }

        private static void TurnOn(char[,] field, char[,] mines, int row, int col)
        {
            char numberOfMines = CalculateMines(mines, row, col);
            mines[row, col] = numberOfMines;
            field[row, col] = numberOfMines;
        }

        private static void UpdatePlayingField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceTheMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] field = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < 15)
            {
                Random random = new Random();
                int number = random.Next(50);
                if (!randomNumbers.Contains(number))
                {
                    randomNumbers.Add(number);
                }
            }

            foreach (int num in randomNumbers)
            {
                int col = num / cols;
                int row = num % cols;
                if (row == 0 && num != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                field[col, row - 1] = '*';
            }

            return field;
        }

        private static char CalculateMines(char[,] mines, int row, int col)
        {
            int number = 0;
            int rows = mines.GetLength(0);
            int cols = mines.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mines[row - 1, col] == '*')
                {
                    number++;
                }
            }

            if (row + 1 < rows)
            {
                if (mines[row + 1, col] == '*')
                {
                    number++;
                }
            }

            if (col - 1 >= 0)
            {
                if (mines[row, col - 1] == '*')
                {
                    number++;
                }
            }

            if (col + 1 < cols)
            {
                if (mines[row, col + 1] == '*')
                {
                    number++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (mines[row - 1, col - 1] == '*')
                {
                    number++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (mines[row - 1, col + 1] == '*')
                {
                    number++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (mines[row + 1, col - 1] == '*')
                {
                    number++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (mines[row + 1, col + 1] == '*')
                {
                    number++;
                }
            }

            return char.Parse(number.ToString());
        }
    }
}
