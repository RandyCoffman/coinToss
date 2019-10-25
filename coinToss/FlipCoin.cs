using System;

namespace coinToss
{
    class FlipCoin
    {
        private static readonly Random rnd = new Random();
        private int headsCount = 0;
        private int tailsCount = 0;

        public void Toss(int flips)
        {
            for (int i = 0; i < flips; i++) {
                if (rnd.NextDouble() >= 0.5) {
                    headsCount++;
                } else {
                    tailsCount++;
                }
            }
            Console.WriteLine("We fliped the coin {0} times." +
                " We flipped it on Head {1} times and we flipped it on Tails {2} times.", flips, headsCount, tailsCount );
        }
    }
}
