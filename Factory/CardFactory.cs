using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Factory
{
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }

    public enum CARDTYPE
    {
        BASIC,
        PLATINUM,
        GOLD
    }
}
