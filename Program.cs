using System;

namespace challenge_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Choose a number!");

    int magicNum;

      Random n = new Random();
      magicNum = n.Next(1, 101);
      System.Console.WriteLine(magicNum);

      bool playing = true;
      while(playing) 
      {
        string guessedStr = Console.ReadLine();
        int numGuess;
        if(!Int32.TryParse(guessedStr, out numGuess))
        {
            System.Console.WriteLine("That is not a number");
          continue;
        }
        if(numGuess == magicNum) 
        {
            System.Console.WriteLine("winner");
            System.Console.WriteLine("play again? (y/n)");
            string play = Console.ReadLine();
            if(play.ToLower() != "y")
            {
                playing = false;
            }
            else 
            {
            magicNum = n.Next(1, 101);
            System.Console.WriteLine("choose a number");
            continue;
          }
        }
        else if (numGuess > magicNum) 
        {
            System.Console.WriteLine("too high");
        }
        else 
        {
            System.Console.WriteLine("too low");
        }
      }


    }
    }
}
