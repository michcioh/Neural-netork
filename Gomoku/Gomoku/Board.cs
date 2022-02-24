using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gomoku
{
    public class Board
    {
        public Position[,] Positions { get; private set; }
        //public String StrBoard { get; private set; }

        public Position.Player WhoHasMove = Position.Player.Black;
        public int MoveNoMade { get; private set; }

        public Board()
        {
            Positions = new Position[15, 15];

            for (int r = 0; r < 15; r++)
            {
                for (int c = 0; c < 15; c++)
                {
                    Positions[r, c] = new Position()
                    {
                        R = r,
                        C = c,
                        Owner = Position.Player.None
                    };
                }
            }

            MoveNoMade = -1;
        }

        public Board Rotate90Deg()
        {
            Board retBoard = new Board()
            {
                MoveNoMade = this.MoveNoMade,
                WhoHasMove = this.WhoHasMove
            };

            // before -> after
            // 00.00  -> 00.14
            // 01.00  -> 00.13
            // 02.00  -> 00.12

            // 14.00  -> 00.00
            // 13.00  -> 00.01

            // 01.01  -> 01.13
            // 01.02  -> 02.13
            // 13.14  -> 14.14-13=1
            // r.c    -> c.14-r

            foreach (Position position in Positions)
            {
                if (position.Owner != Position.Player.None)
                {
                    Position rotatedPosition = position.rotate90Deg();
                    retBoard.Positions[rotatedPosition.R, rotatedPosition.C].Owner = position.Owner;
                }
            }

            /*for (int r = 0; r < 15; r++)
            {
                for (int c = 0; c < 15; c++)
                {
                    Position rotatedPosition = rotatePosition(this.Positions[r, c]);
                    retBoard.Positions[rotatedPosition.R, rotatedPosition.C].Owner = this.Positions[r, c].Owner;
                    //retBoard.Positions[c, 14 - r] = this.Positions[r, c].Clone();
                }
            }*/

            return retBoard;
        }

        public Board Shift(int shiftR, int shiftC)
        {
            Board retBoard = new Board()
            {
                MoveNoMade = this.MoveNoMade,
                WhoHasMove = this.WhoHasMove
            };

            // check if board can be shifted
            foreach (Position position in Positions)
            {
                if (position.Owner != Position.Player.None)
                {
                    if (Board.IsCoordinateOK(position.R + shiftR) && Board.IsCoordinateOK(position.C + shiftC))
                    {
                        // shift
                        retBoard.Positions[position.R + shiftR, position.C + shiftC] = position.Clone();
                    }
                    else // can't shift owned positions
                    {
                        return null;
                    }
                }
            }

            return retBoard;
        }

        public static bool IsCoordinateOK (int coordinate)
        {
            return (coordinate >= 0 && coordinate < 15);
        }

        public Board Clone()
        {
            Board board = new Board();

            for (int r = 0; r < 15; r++)
            {
                for (int c = 0; c < 15; c++)
                {
                    board.Positions[r, c] = this.Positions[r, c].Clone();
                }
            }

            board.WhoHasMove = this.WhoHasMove;
            board.MoveNoMade = this.MoveNoMade;

            return board;
        }

        public void MakeMove(Position position)
        {
            position.Owner = position.MovingPlayer;
            Positions[position.R, position.C] = position;
            WhoHasMove = WhoHasMove == Position.Player.Black ? Position.Player.White : Position.Player.Black;
            MoveNoMade++;
        }

        public void Print()
        {
            int idx = 0;
            String strBoardToPrint = this.ToString().Replace(";", "");

            Console.WriteLine("******************* Stan tabeli *******************");
            Console.Write(" ");

            for (int c = 0; c < 15; c++) 
            {
                Console.Write(c % 10);
            }

            Console.WriteLine();

            for (int r = 0; r < 15; r++)
            {
                Console.Write(r % 10);

                for (int c = 0; c < 15; c++)
                {
                    Console.Write(strBoardToPrint[idx++]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************");
        }

        public override String ToString()
        {
            String StrState = "";
            
            for (int r = 0; r < 15; r++)
            {
                for (int c = 0; c < 15; c++)
                {
                    if (StrState.Length > 0)
                    {
                        StrState += ";";
                    }

                    switch (Positions[r, c].Owner)
                    {
                        case Position.Player.Black:
                            StrState += "B";
                            break;

                        case Position.Player.White:
                            StrState += "W";
                            break;

                        case Position.Player.None:
                            StrState += "+";
                            break;
                    }

                }
            }

            return StrState;
        }

        public enum RotateDegrees
        {
            DEG_90,
            DEG_180,
            DEG_270
        }
    }
}
