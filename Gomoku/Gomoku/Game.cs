using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Gomoku
{
    public class Game
    {
        public String Path { get; private set; }
        public Board Board { get; private set; }
        public List<Move> Moves { get; private set; }
        public bool PositionsLoadedOK { get; private set; }
        public bool GameWasFinished { get; private set; }
        public String errMsg { get; private set; }
        public String Date { get; private set; }
        public Position.Player Winner { get; private set; }

        public Game()
        {
            Path = null;
            Board = new Board();
            Moves = new List<Move>();

            PositionsLoadedOK = true;
            GameWasFinished = false;
        }

        public Game(String path)
        {
            Path = path;
            Board = new Board();
            Moves = new List<Move>();

            PositionsLoadedOK = true;
            GameWasFinished = true;
            GetGameDetailsFromGameFile();
        }

        public void MakeMove(Position movingPosition)
        {
            Move move = new Move()
            {
                BoardBeforeMove = Board.Clone(),
                MoveMade = movingPosition,
                MoveNo = Moves.Count
            };

            Moves.Add(move);
            Board.MakeMove(movingPosition);
        }

        private void GetGameDetailsFromGameFile()
        {
            /*  012345678901234567890
                [Event "?"]
                [Site "PlayOK"]
                [Date "2021.01.17"]
                [Round "-"]
                [Black "mgg1521g"]
                [White "tcd3990g"]
                012345678901234567890
                [Result "0-1"]
                [Time "23:25:22"]
                [TimeControl "300"]
                [GameType "60,15"]
                [BlackElo "1039"]
                [WhiteElo "1181"]            
             */

            try
            {
                #region Reading game infos
                StreamReader sr = new StreamReader(Path);

                String line = sr.ReadLine();
                String moves = "";
                bool linesContainsMoves = false;

                while (line != null)
                {
                    if (linesContainsMoves)
                    {
                        moves += " " + line;
                    }
                    else
                    {
                        if (line.Length == 0)
                        {
                            linesContainsMoves = true;
                        }
                        else
                        {
                            if (line.StartsWith("[Date"))
                            {
                                Date = line.Substring(7, 10);
                            }
                            else if (line.StartsWith("[Result"))
                            {
                                if (line.Equals("[Result \"0-1\"]"))
                                {
                                    Winner = Position.Player.White;
                                }
                                else if (line.Equals("[Result \"1-0\"]"))
                                {
                                    Winner = Position.Player.Black;
                                }
                                else if (line.Equals("[Result \"1/2-1/2\"]"))
                                {
                                    Winner = Position.Player.None;
                                }
                                else
                                {
                                    Console.WriteLine("------> " + line);
                                }
                            }
                            else if (line.StartsWith("[Event"))
                            {
                                if (!line.Equals("[Event \"?\"]"))
                                {
                                    Console.WriteLine();
                                }
                            }
                        }
                    }

                    line = sr.ReadLine();
                }

                sr.Close();
                #endregion

                #region Positions
                String[] tab = moves.Split(' ');

                Position.Player movingPlayer = Position.Player.Black;

                int moveNo = 0;
                foreach (String element in tab)
                {
                    if (!element.Contains(".") && !element.Contains("-") && element.Length > 0)
                    {
                        Position p = GetPosition(element);

                        if (p != null)
                        {
                            p.MovingPlayer = movingPlayer;

                            Move move = new Move()
                            {
                                BoardBeforeMove = Board.Clone(),
                                MoveMade = p,
                                MoveNo = moveNo++
                            };

                            Moves.Add(move);
                            Board.MakeMove(p);
                        }
                        else
                        {
                            PositionsLoadedOK = false;
                            return;
                        }
                    }

                    movingPlayer = movingPlayer == Position.Player.Black ? Position.Player.White : Position.Player.Black;
                }
                #endregion

                if ((Winner == Position.Player.Black && Moves.Count % 2 == 0) ||
                    (Winner == Position.Player.White && Moves.Count % 2 != 0)) 
                {
                    GameWasFinished = false;
                }
            }
            catch (Exception e)
            {
                PositionsLoadedOK = false;
                errMsg = e.Message;
                //Console.WriteLine(e.Message);
            }
        }
        private Position GetPosition(String kurnikCoordinates)
        {
            try
            {
                Char c = kurnikCoordinates[0];
                int i = int.Parse(kurnikCoordinates.Substring(1));


                return new Position()
                {
                    R = 15 - i,
                    C = (int)c - (int)'a'
                };
            }
            catch (Exception e)
            {
                errMsg = "GetPosition(\"" + kurnikCoordinates + "\")";
                //Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
