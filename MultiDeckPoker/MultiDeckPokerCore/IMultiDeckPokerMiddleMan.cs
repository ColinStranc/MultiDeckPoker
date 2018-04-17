using System;
namespace MultiDeckPokerCore
{
    public interface IMultiDeckPokerMiddleMan
    {

        int CreateStandard1DeckTable();

        void SitDown(String Player);

        void SetPlayNextRound(String player, bool playNextRound);

        PokerAction GetPlayerAction(String player);

        void StartGame();
    }
}
