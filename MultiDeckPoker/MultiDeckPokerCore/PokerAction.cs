using System;
namespace MultiDeckPokerCore
{
    public class PokerAction
    {
        public static PokerAction CreateBet(int betSize)
        {
            return new PokerAction(betSize);
        }

        // RaiseSize is the amount you raise the previous bet.
        // The amount you will taking out of your money to add to the pot is
        //  amount needed to call + raiseSize
        public static PokerAction CreateRaise(int raiseSize)
        {
            return new PokerAction(raiseSize);
        }

        public static PokerAction CreateCall()
        {
            return new PokerAction(0);
        }

        public static PokerAction CreateCheck()
        {
            return new PokerAction(0);
        }

        public static PokerAction CreateFold()
        {
            return new PokerAction(-1);
        }

        /*
         * #####################################
         * */
        private readonly int _raiseSize;

        private PokerAction(int raiseSize)
        {
            _raiseSize = raiseSize;
        }

        public PokerActionType GetActionType()
        {
            if (_raiseSize < 0)
            {
                return PokerActionType.FOLD;
            }

            if (_raiseSize == 0)
            {
                return PokerActionType.CALL;
            }

            return PokerActionType.RAISE;
        }

        public int GetRaiseSize()
        {
            if (GetActionType() != PokerActionType.BET && GetActionType() != PokerActionType.RAISE)
            {
                throw new Exception("Cannot Get Bet Size for " + GetActionType());
            }

            return _raiseSize;
        }
    }
}
