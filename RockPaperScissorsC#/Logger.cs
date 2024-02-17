using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsC_
{
    internal class Logger
    {
       string introduction = "Hello there! Let's play a quick game of rock, paper & scissors!\n Pick your choice by entering its number, and reveal it after 3 seconds have passed.";
       string items = "1. Rock \n2. Paper \n3. Scissors";
       string gameStartText = "Prepare your choices in:";
        public void LogIntroduction()
        {
            Console.WriteLine(introduction);
        }
        public void LogChoices()
        {
            Console.WriteLine(items);
        }
        public void LogPlayerChoice(string playerInput)
        {
            Console.WriteLine($"You chose: {playerInput}");
        }
        public void LogComputerChoice(string compInput)
        {
            Console.WriteLine($"Computers choice: {compInput}");
        }
        public void LogError()
        {
            Console.WriteLine("Invalid input. Starting again...\n");
        }
        public void LogPlayerWin()
        {
            Console.WriteLine("You win!");
        }
        public void LogComputerWin()
        {
            Console.WriteLine("Computer wins!");
        }
        public void LogDraw()
        {
            Console.WriteLine("It's a draw!");
        }
        public void LogStart()
        {
        Console.WriteLine(gameStartText);
        for(int second = 3; second > 0; second--)
        {   
            Console.WriteLine(second);
            Thread.Sleep(1000);
        }
        }
}
}
