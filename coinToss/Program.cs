using System;

namespace coinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            string redo;
            string checkSum;
            FlipCoin coin = new FlipCoin();
            Console.WriteLine("Welcome to my coin flipping game!");
            Console.WriteLine("How many times would you like the coin to flip?");
            checkSum = Console.ReadLine();

            int flips;
            while (int.TryParse(checkSum, out flips) == false)
            {
                Console.WriteLine("Enter a valid number. No letters and decimal places are allowed.");
                checkSum = Console.ReadLine();
            }
            flips = Convert.ToInt32(checkSum);
            coin.Toss(flips);
            Console.WriteLine("Do you want to try again?");
            redo = Console.ReadLine();
            switch (redo.Trim().ToLower()) {
                case "y":
                case "yes":
                    Main(null);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
