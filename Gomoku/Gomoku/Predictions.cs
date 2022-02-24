using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gomoku
{
    public class Predictions
    {
        public double[,] PredictionsByKnownStrinct { get; set; }
        public double[,] PredictionsByKnownAfterRotation { get; set; }
        public double[,] PredictionsByKnownAfterShift { get; set; }
        public int[,] PredictionsByKnownCalculated { get; set; }
        public List<Game> GamesBlackWon { get; set; }
        public List<Game> GamesWhiteWon { get; set; }
        public int maxPredicionCalculated { get; private set; }

        const double PREDICTION_STRINCT_WEIGHT = 1.0;
        const double PREDICTION_AFTER_ROTATION_WEIGHT = 1.0;
        const double PREDICTION_AFTER_SHIFT_WEIGHT = 0.6;

        const int MIN_SHIFT = -7;
        const int MAX_SHIFT = 7;

        public Predictions()
        {
            PredictionsByKnownStrinct = new double[15, 15];
            PredictionsByKnownAfterRotation = new double[15, 15];
            PredictionsByKnownAfterShift = new double[15, 15];
            PredictionsByKnownCalculated = new int[15, 15];
            GamesBlackWon = new List<Game>();
            GamesWhiteWon = new List<Game>();
        }

        public void CountPredictions(Board board)
        {
            for (int r = 0; r < 15; r++)
            {
                for (int c = 0; c < 15; c++)
                {
                    PredictionsByKnownStrinct[r, c] = 0;
                    PredictionsByKnownAfterRotation[r, c] = 0;
                    PredictionsByKnownAfterShift[r, c] = 0;
                    PredictionsByKnownCalculated[r, c] = 0;
                }
            }

            foreach (Game game in board.WhoHasMove == Position.Player.Black ? GamesBlackWon : GamesWhiteWon)
            {
                PredictGame(board, game);
            }

            CountPredictionsByKnownCalculated();
        }

        public void CountPredictionsByKnownCalculated()
        {
            maxPredicionCalculated = 0;

            for (int r = 0; r < 15; r++)
            {
                for (int c = 0; c < 15; c++)
                {
                    int predicionCalculated = (int) Math.Round(PredictionsByKnownStrinct[r, c] +
                        PredictionsByKnownAfterRotation[r, c] +
                        PredictionsByKnownAfterShift[r, c]);

                    PredictionsByKnownCalculated[r, c] += predicionCalculated;

                    if (predicionCalculated > maxPredicionCalculated)
                    {
                        maxPredicionCalculated = predicionCalculated;
                    }
                }
            }
        }

        public bool PredictGame(Board board, Game gameWithPredictionMoves)
        {
            int moveToDoNo = board.MoveNoMade + 1;

            if (gameWithPredictionMoves.Moves.Count <= moveToDoNo)
                return false;

            Move move = gameWithPredictionMoves.Moves[moveToDoNo];

            bool found = PredictStrinct(board, move);

            if (!found)
            {
                found = PredictRotate(board, move);

                if (!found)
                {
                    found = PredictShift(board, move);
                }
            }

            return found;

            /*Console.WriteLine("I will check move no " + move.MoveNo);

            if (move.BoardBeforeMove.ToString().Equals(board.ToString()))
            {
                PredictionsByKnown[move.MoveMade.R, move.MoveMade.C]++;
                return;
            }*/

            /*
            // rotation 90 deg.
            Board rotatedBoard = move.BoardBeforeMove.Rotate90Deg();

            if (rotatedBoard.ToString().Equals(board.ToString()))
            {
                PredictionsByKnownAfterRotation[move.MoveMade.C, 14 - move.MoveMade.R]++;
                return;
            }

            // rotation 180 deg.
            rotatedBoard = rotatedBoard.Rotate90Deg();

            if (rotatedBoard.ToString().Equals(board.ToString()))
            {
                PredictionsByKnownAfterRotation[move.MoveMade.C, 14 - move.MoveMade.R]++;
                return;
            }

            // rotation 270 deg.
            rotatedBoard = rotatedBoard.Rotate90Deg();

            if (rotatedBoard.ToString().Equals(board.ToString()))
            {
                PredictionsByKnownAfterRotation[move.MoveMade.C, 14 - move.MoveMade.R]++;
                return;
            }*/

            /*
            // shift
            for (int shiftR = -14; shiftR < 15; shiftR++)
            {
                for (int shiftC = -14; shiftC < 15; shiftC++)
                {

                }
            }*/
        }

        public bool PredictStrinct(Board board, Move move)
        {
            Console.WriteLine("I will check move no " + move.MoveNo);

            if (move.BoardBeforeMove.ToString().Equals(board.ToString()))
            {
                PredictionsByKnownStrinct[move.MoveMade.R, move.MoveMade.C] += PREDICTION_STRINCT_WEIGHT;
                return true;
            }

            return false;
        }

        public bool PredictRotate(Board board, Move move)
        {
            // rotation 90 deg.
            Board rotatedBoard = board.Rotate90Deg();

            if (rotatedBoard.ToString().Equals(move.BoardBeforeMove.ToString()))
            {
                Position predictedPosition = move.MoveMade.rotate90Deg().rotate90Deg().rotate90Deg();
                PredictionsByKnownAfterRotation[predictedPosition.R, predictedPosition.C] += PREDICTION_AFTER_ROTATION_WEIGHT;
                
                return true;
            }

            // rotation 180 deg.
            rotatedBoard = rotatedBoard.Rotate90Deg();

            if (rotatedBoard.ToString().Equals(move.BoardBeforeMove.ToString()))
            {
                Position predictedPosition = move.MoveMade.rotate90Deg().rotate90Deg();
                PredictionsByKnownAfterRotation[predictedPosition.R, predictedPosition.C] += PREDICTION_AFTER_ROTATION_WEIGHT;
                return true;
            }

            // rotation 270 deg.
            rotatedBoard = rotatedBoard.Rotate90Deg();

            if (rotatedBoard.ToString().Equals(move.BoardBeforeMove.ToString()))
            {
                Position predictedPosition = move.MoveMade.rotate90Deg();
                PredictionsByKnownAfterRotation[predictedPosition.R, predictedPosition.C] += PREDICTION_AFTER_ROTATION_WEIGHT;
                //PredictionsByKnownAfterRotation[move.MoveMade.C, 14 - move.MoveMade.R]++;
                return true;
            }

            return false;
        }

        public bool PredictShift(Board board, Move move)
        {
            // shift
            for (int shiftR = MIN_SHIFT; shiftR <= MAX_SHIFT; shiftR++)
            {
                for (int shiftC = MIN_SHIFT; shiftC <= MAX_SHIFT; shiftC++)
                {
                    Board boardBeforeMoveAfterShift = move.BoardBeforeMove.Shift(shiftR, shiftC);
                    
                    if (boardBeforeMoveAfterShift != null) {
                        if (boardBeforeMoveAfterShift.ToString().Equals(board.ToString())) {
                            
                            int destinyR = move.MoveMade.R + shiftR;
                            int destinyC = move.MoveMade.C + shiftC;
                            
                            if (Board.IsCoordinateOK(destinyR) && Board.IsCoordinateOK(destinyC))
                            {
                                PredictionsByKnownAfterShift[destinyR, destinyC] += PREDICTION_AFTER_SHIFT_WEIGHT;
                            }
                        }
                    }
                }
            }

            return false;
        }
    }
}
