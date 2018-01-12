using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SlidingPuzzleGame.Classes
{
    class Board
    {
        public Square[] squares = new Square[9];
        Square[,] map = new Square[3, 3];

        private int[] winOrder = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

        private Square spaceSquare;

        public void AddSquare(Square sq)
        {
            squares[sq.number] = sq;
        }

        public void PositionSquares() //just puts the squres into a map
        {
            int current = 0;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    //Console.WriteLine(current);
                    if (i == map.GetLength(0)-1 && j == map.GetLength(1)-1) // the very last piece of puzzle that will be missing
                    {
                        squares[current].isSpace = true;
                        spaceSquare = squares[current];
                        //Console.WriteLine(squares[i + j].number);
                        map[i, j] = squares[current];
                    }
                    else
                    {
                        map[i, j] = squares[current];
                    }
                    current++;
                }
            }
            //shuffle map
            ShuffleMap();
        }

        public void ShuffleMap()
        {
            Random r = new Random();
            int seed = r.Next(1500);
            Shuffle(map, seed);
            RedrawAllSquares();
        }

        public Square GetSquare (int ID)
        {
            //GetActiveSquares();
            int current = 0;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (current == ID)
                        return map[i, j];
                    current++;
                }
            }

            return null; //something went wrong
        }

        public bool isWon()
        {
            int current = 0;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j].number != winOrder[current])
                        return false;
                    current++;
                }
            }
            return true;
        }

        public void MoveSquareToSpace(Square sq)
        {
            //switch spaces
            //indexes to swap elements
            int i1 = 0;
            int j1 = 0;
            int i2 = 0;
            int j2 = 0;

            //switch sq places
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i,j].number == spaceSquare.number)
                    {
                        i1 = i;
                        j1 = j;
                    }
                    if (map[i,j].number == sq.number)
                    {
                        i2 = i;
                        j2 = j;
                    }
                }
            }

            map[i1, j1].isSpace = true;
            map[i2, j2].isSpace = false;

            //swap elements in map
            Square tempSq = map[i1, j1];
            map[i1, j1] = map[i2, j2];
            map[i2, j2] = tempSq;

            //spaceSquare = sq;

            RedrawAllSquares();

            isWon();
        }

        public void RedrawAllSquares()
        {
            foreach(Square sq in squares)
            {
                sq.box.Invalidate();
                if (sq.isSpace)
                    spaceSquare = sq;
            }
        }


        public List<Square> GetActiveSquares() // gets the activate squares that can be moved
        {
            List<Square> tmpList = new List<Square>();

            //set the active squares
            int current = 0;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    //Console.WriteLine("Square: " +  squares[current].isSpace);
                    if (map[i,j].isSpace)
                    {
                        //Console.WriteLine("FoundSpace at: "  + " space in map: " + map[i,j].number);
                        //add left square if present
                        if ((j - 1) >= 0)
                            tmpList.Add(map[i, j - 1]);
                        //add right square if present
                        if ((j+1) < map.GetLength(1))
                            tmpList.Add(map[i, j + 1]);
                        //add top sqaure if present
                        if ((i - 1) >= 0)
                            tmpList.Add(map[i - 1, j]);
                        //add bottom square if present
                        if ((i+ 1) < map.GetLength(0))
                            tmpList.Add(map[i + 1, j]);
                    }

                    current++;
                }
            }

            return tmpList;
        }

        //Fisher-Yates algorithm to shuffle lists
        public static void Shuffle<T>(T[,] array, int seed)
        {
            var rng = new Random(seed);
            int lengthRow = array.GetLength(1);

            for (int i = array.Length - 1; i > 0; i--)
            {
                int i0 = i / lengthRow;
                int i1 = i % lengthRow;

                int j = rng.Next(i + 1);
                int j0 = j / lengthRow;
                int j1 = j % lengthRow;

                T temp = array[i0, i1];
                array[i0, i1] = array[j0, j1];
                array[j0, j1] = temp;
            }
        }
    }
}
