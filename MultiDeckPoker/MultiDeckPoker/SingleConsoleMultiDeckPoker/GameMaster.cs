using System;
using MultiDeckPokerCore;

namespace MultiDeckPoker.SingleConsoleMultiDeckPoker
{
    public class GameMaster
    {
        private IMultiDeckPokerMiddleMan _middleMan;
        private IConsoleReader _reader;

        public GameMaster(IMultiDeckPokerMiddleMan middleMan, IConsoleReader reader)
        {
            _middleMan = middleMan;
            _reader = reader;
        }

        public void PlayGame()
        {
            int tableId = SetUpTable();

            _middleMan.StartGame();
        }

        private int SetUpTable()
        {
            int tableId = _middleMan.CreateStandard1DeckTable();

            string[] players = _reader.GetPlayerNames();

            foreach (string player in players)
            {
                _middleMan.SitDown(player);
                _middleMan.SetPlayNextRound(player, true);
            }

            return tableId;
        }
    }
}
