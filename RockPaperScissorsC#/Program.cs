using RockPaperScissorsC_;
  void Game()
{
Logger logger = new Logger();
Rules rules = new Rules();
Random gameDestiny = new Random();

string[] battleItems = rules.BattleItems;

int gameDestinyNum = gameDestiny.Next(3);

logger.LogIntroduction();
logger.LogChoices();

string playerInput = Console.ReadLine();

int choiceIndex;
    if (int.TryParse(playerInput, out choiceIndex))
    {
        string selectedChoice = battleItems[choiceIndex - 1];
        string computersChoice = battleItems[gameDestinyNum - 1];
        logger.LogStart();
        logger.LogPlayerChoice(selectedChoice);
        logger.LogComputerChoice(computersChoice);
        rules.GameResult(selectedChoice, computersChoice);
    }
    else
    {
        logger.LogError();
        Game();
    }
}

Game();

