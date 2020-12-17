using System;
using System.Collections.Generic;

namespace rps_multiple_users
{
    class Player
    {
        private Guid playerId = new Guid();
        public Guid PlayerId
        { 
            get
            {
                return playerId;
            }
        }

        private int totalWins;
        private int totalLosses;
        private string fName;
        public string FName
        {
            get { return fName; }
            set 
            {  
                if (value is string && value.Length <20 && value.Length > 0)
                {
                fName = value; 
                }
                else {
                    throw new Exception("The name you sent is not valid");
                }
            }
        }

        private string lName;
        public string LName
        {
            get { return lName; }
            set 
            {  
                if (value is string && value.Length <20 && value.Length > 0)
                {
                lName = value; 
                }
                else {
                    throw new Exception("The name you sent is not valid");
                }
            }
        }

        public void AddWin() {
            totalWins ++;
        }

        public void AddLoss() {
            totalLosses ++;
        }

        public int[] GetWinLossRecord() {
            int[] winsAndLosses = new int[2];
            winsAndLosses[0] = totalWins;
            winsAndLosses[1] = totalLosses;
            return winsAndLosses;
        }
    }
}