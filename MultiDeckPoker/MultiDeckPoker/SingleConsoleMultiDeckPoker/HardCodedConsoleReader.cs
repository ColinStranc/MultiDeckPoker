using System;
namespace MultiDeckPoker.SingleConsoleMultiDeckPoker
{
    public class HardCodedConsoleReader : IConsoleReader
    {
        public string[] GetPlayerNames()
        {
            Console.Out.WriteLine("Enter player names:");

            string[] names = { "Adam", "Bob", "Clive", "Dee" };
            foreach(string name in names)
            {
                Console.Out.WriteLine(name);
            }

            Console.Out.WriteLine("Finished reading names.");

            return names;
        }
    }
}
