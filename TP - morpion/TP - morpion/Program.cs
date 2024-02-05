using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|| MORPION ||");
            string namePlayerOne = AssignNameToPlayer(1);
            string namePlayerTwo = AssignNameToPlayer(2);
            char signPlayerOne = AssignSignToPlayerOne(namePlayerOne);
            char signPlayerTwo = AssignSignToPlayerTwo(signPlayerOne);
            bool playing = false;
            

            do
            {
                char[,] grid =
                {
                    { ' ', ' ', ' ' },
                    { ' ', ' ', ' ' },
                    { ' ', ' ', ' ' }
                };
                while (!EndOfTheGame(grid, signPlayerOne, signPlayerTwo))
                {
                    PlayingRound(namePlayerOne, signPlayerOne, grid);

                    if (!EndOfTheGame(grid, signPlayerOne, signPlayerTwo))
                    {
                        PlayingRound(namePlayerTwo, signPlayerTwo, grid);
                    }
                }

                DisplayEndMessage(grid, namePlayerOne, signPlayerOne, namePlayerTwo, signPlayerTwo);
                playing = Replay();
            } while (playing);
            

        }
        public static string AssignNameToPlayer(int playerNumber)
        {
            Console.Write("Joueur " + playerNumber + " : quel est votre prénom ?\t");
            string namePlayer = Console.ReadLine();
            return namePlayer;
        }

        public static char AssignSignToPlayerOne(string namePlayerOne)
        {
            Console.Write("\n" + namePlayerOne + " : X ou O ?\t\t\t\t");
            string signPlayerOne = Console.ReadLine();
            while (signPlayerOne != "X" && signPlayerOne != "O")
            {
                Console.WriteLine("Erreur : veuillez réessayer");
                signPlayerOne = Console.ReadLine();
            }
            if (signPlayerOne == "X")
            {
                return 'X';
            } else
            {
                return 'O';
            }
        }
        
        public static char AssignSignToPlayerTwo(char signPlayerOne)
        {
            if (signPlayerOne == 'X')
            {
                return 'O';
            } else
            {
                return 'X';
            }
        }

        public static void DisplayGrid(char[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i,j]);
                    if (j < (grid.GetLength(1) - 1))
                    {
                        Console.Write("|");
                    }
                }
                if (i < ( grid.GetLength(0) - 1 ) )
                {
                    Console.WriteLine("\n-----");
                }
            }
            Console.WriteLine("");
        }

        public static bool WinningRowBySign(char[,] grid, char playerSign)
        {
            bool result = false;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                if (grid[i, 0] == playerSign && grid[i, 1] == playerSign && grid[i, 2] == playerSign)
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool WinningRow(char[,] grid, char playerOneSign, char playerTwoSign)
        {
            bool result = false;
            if ( WinningRowBySign(grid, playerOneSign) || WinningRowBySign(grid, playerTwoSign) )
            {
                result = true;
            } 
            return result;
        }

        public static bool WinningColumnBySign(char[,] grid, char playerSign)
        {
            bool result = false;
            for (int i = 0; i < grid.GetLength(1); i++)
            {
                if (grid[0, i] == playerSign && grid[1, i] == playerSign && grid[2, i] == playerSign)
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool WinningColumn(char[,] grid, char playerOneSign, char playerTwoSign)
        {
            bool result = false;
            if (WinningColumnBySign(grid, playerOneSign) || WinningColumnBySign(grid, playerTwoSign))
            {
                result = true;
            }
            return result;
        }

        public static bool WinningDiagonalBySign(char[,] grid, char playerSign)
        {
            bool result = false;
            if (grid[0, 0] == playerSign && grid[1, 1] == playerSign && grid[2, 2] == playerSign
                || grid[0, 2] == playerSign && grid[1, 1] == playerSign && grid[2, 0] == playerSign)
            {
                result = true;
            }
            return result;
        }

        public static bool WinningDiagonal(char[,] grid, char playerOneSign, char playerTwoSign)
        {
            bool result = false;
            if (WinningDiagonalBySign(grid, playerOneSign) || WinningDiagonalBySign(grid, playerTwoSign))
            {
                result = true;
            }
            return result;
        }

        public static bool Win(char[,] grid, char playerOneSign, char playerTwoSign)
        {
            bool result = false;
            if (WinningColumn(grid, playerOneSign, playerTwoSign) || WinningDiagonal(grid, playerOneSign, playerTwoSign) || WinningRow(grid, playerOneSign, playerTwoSign))
            {
                result = true;
            }
            return result;
        }

        

        public static bool GridIsFull(char[,] grid)
        {
            int squareIsFilled = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i,j] != ' ')
                    {
                        squareIsFilled++;
                    }
                }
            }
            if (squareIsFilled == 9)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool SquareIsEmpty(char square)
        {
            return square == ' ';
        }

        public static void PlayingRound(string playerName, char signPlayer, char[,] grid)
        {
            char[,] gridIndex =
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
            Console.WriteLine("Grille actuelle :");
            DisplayGrid(grid);
            Console.WriteLine("\nGrille de référence");
            DisplayGrid(gridIndex);
            Console.WriteLine("\n" + playerName + "[" + signPlayer + "] : où voulez-vous placer votre jeton ?");
            string tokenSquareString = Console.ReadLine();
            int tokenSquare = int.Parse(tokenSquareString); // ATTENTION : PAS DE VÉRIF DE TYPAGE, CRASH SI PAS UN INTEGER
            switch(tokenSquare)
            {
                case 1:
                    ChangeSquareValue(grid, playerName, signPlayer, 0, 0);
                    break;
                case 2:
                    ChangeSquareValue(grid, playerName, signPlayer, 0, 1);
                    break;
                case 3:
                    ChangeSquareValue(grid, playerName, signPlayer, 0, 2);
                    break;
                case 4:
                    ChangeSquareValue(grid, playerName, signPlayer, 1, 0);
                    break;
                case 5:
                    ChangeSquareValue(grid, playerName, signPlayer, 1, 1);
                    break;
                case 6:
                    ChangeSquareValue(grid, playerName, signPlayer, 1, 2);
                    break;
                case 7:
                    ChangeSquareValue(grid, playerName, signPlayer, 2, 0);
                    break;
                case 8:
                    ChangeSquareValue(grid, playerName, signPlayer, 2, 1);
                    break;
                case 9:
                    ChangeSquareValue(grid, playerName, signPlayer, 2, 2);
                    break;
            }
            Console.WriteLine("");
        }

        public static bool EndOfTheGame(char[,] grid, char playerOneSign, char playerTwoSign)
        {
            return Win(grid, playerOneSign, playerTwoSign) || GridIsFull(grid);
        }

        public static void ChangeSquareValue(char[,] grid, string playerName, char signPlayer, int row, int column)
        {
            if (SquareIsEmpty(grid[row, column]))
                grid[row, column] = signPlayer;
            else
            {
                PlayingRound(playerName, signPlayer, grid);
            }
        }

        public static void DisplayEndMessage(char[,] grid, string playerOneName, char playerOneSign, string playerTwoName, char playerTwoSign)
        {
            if (GridIsFull(grid))
            {
                Console.WriteLine("Aucun gagnant...");
            } else if (WinningColumnBySign(grid, playerOneSign) || WinningDiagonalBySign(grid, playerOneSign) || WinningRowBySign(grid, playerOneSign))
            {
                Console.WriteLine(playerOneName + " gagne !");
            } else
            {
                Console.WriteLine(playerTwoName + " gagne !");
            }
        }

        public static bool Replay()
        {
            Console.WriteLine("\nVoulez-vous rejouer (y/n) ?");
            string inputPlaying = Console.ReadLine();
            while (inputPlaying != "y" && inputPlaying != "n")
            {
                Console.WriteLine("\nErreur : veuillez réessayer (y/n).");
                inputPlaying = Console.ReadLine();
            }
            if (inputPlaying == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}