using System;
using System.Collections.Generic;

namespace rps_multiple_users
{
    class Round
    {
        private Guid roundId = new Guid();
        public Guid RoundId { get {return roundId; }}
        public Choice Player1Choice { get; set; } // cpu
        public Choice Player2Choice { get; set; } // player

        public Player WinningPlayer { get; set; } = null; // assign who won
    }
}