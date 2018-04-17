using System;
using MultiDeckPokerCore;

namespace MultiDeckPoker.SingleConsoleMultiDeckPoker
{
    public class ConsoleMultiDeckPokerCoreMiddleMan : MultiDeckPokerCoreMiddleMan
    {
        public ConsoleMultiDeckPokerCoreMiddleMan()
        {
        }

        public override PokerAction GetPlayerAction(String player)
        {
            return PokerAction.CreateCheck();
        }
    }
}
