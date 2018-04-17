using System;
namespace MultiDeckPokerCore
{
    public abstract class MultiDeckPokerCoreMiddleMan : IMultiDeckPokerMiddleMan
    {
        public int CreateStandard1DeckTable()
        {
            // Do Nothing For His Stubbyness

            // Returns Table ID, return 0 for now.
            return 0;
        }

        public void SitDown(String player)
        {
            
        }

        public void SetPlayNextRound(String player, bool playNextRound)
        {
            // Also a nothing do-er
        }

        public void StartGame()
        {
            
        }

        public abstract PokerAction GetPlayerAction(String player);
    }
}
