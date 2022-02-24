using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gomoku
{
    public class Position
    {
        public int R { get; set; }
        public int C { get; set; }
        public Player MovingPlayer { get; set; }
        public Player Owner { get; set; }

        public Position Clone()
        {
            Position position = new Position()
            {
                C = this.C,
                MovingPlayer = this.MovingPlayer,
                Owner = this.Owner,
                R = this.R
            };

            return position;
        }

        public  Position rotate90Deg()
        {
            Position retPosition = this.Clone();

            int r = this.R;
            int c = this.C;

            retPosition.R = c;
            retPosition.C = 14 - r;

            return retPosition;
        }

        public enum Player
        {
            White,
            Black,
            None
        }
    }
}
