using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsC_
{
    public class Rules
    {
       public string[] BattleItems = { "Rock", "Paper", "Scissors" };
   
        Logger logger = new Logger();

        public void GameResult(string playerInput, string computerInput)
        {
            if(playerInput == computerInput)
                logger.LogDraw();
            {
                if (playerInput == "Rock" && computerInput == "Paper")
                {
                    logger.LogComputerWin();
                }
                if (playerInput == "Rock" && computerInput == "Scissors")
                {
                    logger.LogPlayerWin();
                }
                if (playerInput == "Paper" && computerInput == "Rock")
                {
                    logger.LogPlayerWin();
                }
                if (playerInput == "Paper" && computerInput == "Scissors")
                {
                    logger.LogComputerWin();
                }
                if (playerInput == "Scissors" && computerInput == "Paper")
                {
                    logger.LogPlayerWin();
                }
                if (playerInput == "Scissors" && computerInput == "Rock")
                {
                    logger.LogComputerWin();
                }
            }

        }
    }
}
