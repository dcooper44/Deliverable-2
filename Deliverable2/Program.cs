using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess which will have more: Heads or Tails? ");
            string headsOrTailsGuess = Console.ReadLine();
            headsOrTailsGuess = headsOrTailsGuess.ToLower();
            Console.Write("How many times shall we flip a coin? ");            
            double numberOfFlips = Convert.ToDouble(Console.ReadLine());
            double correctCount = 0;
            var randomNumber = new Random();

            for(int i = 1; i <= numberOfFlips; i++)
            {
                
                if (headsOrTailsGuess == "heads")
                {
                    if ((randomNumber.Next(6) % 2) == 0)
                    {
                        correctCount += 1;
                        Console.WriteLine("Heads");

                    }
                    else
                    {
                    Console.WriteLine("Tails");
                    }
                }
                else
                {
                    if ((randomNumber.Next(6) % 2) != 0)
                    {
                        correctCount += 1;
                        Console.WriteLine("Tails");
                    }
                  else
                    {
                        Console.WriteLine("Heads");
                    }      
                }
            
            }
            Console.WriteLine("Your Guess, " + headsOrTailsGuess + ", came up " + correctCount + " time(s)");
            Console.WriteLine("That's " + ((correctCount / numberOfFlips) * 100) + " percent");
                

              
            
        }
    }
}
