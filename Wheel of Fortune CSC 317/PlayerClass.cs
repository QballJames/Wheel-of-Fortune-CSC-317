using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel_of_Fortune_CSC_317
{
    public class PlayerClass
    {
            public String playerName;
            public int playerScore;
            public bool wordGuessed;

        public PlayerClass()
        {
            playerName = " ";
            playerScore = 0;
            wordGuessed = false;
        }
    }
}
