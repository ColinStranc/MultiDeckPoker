using System;
using MultiDeckPoker.SingleConsoleMultiDeckPoker;

namespace MultiDeckPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Console Multi Deck Poker.");
            try
            {
                GameMaster game = new GameMaster(new ConsoleMultiDeckPokerCoreMiddleMan(), new HardCodedConsoleReader());
                game.PlayGame();

                Console.WriteLine("Finished With an Astounding Lack of Errors.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
