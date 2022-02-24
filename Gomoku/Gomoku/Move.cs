using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gomoku
{
    public class Move
    {
        public Board BoardBeforeMove { get; set; }
        public Position MoveMade { get; set; }

        public int MoveNo { get; set; }
    }
}
