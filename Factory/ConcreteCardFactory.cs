using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Factory
{
    class ConcreteCardFactory : CardFactory
    {
        private readonly int _annualCharge;
        private readonly CARDTYPE _cardtype;

        public ConcreteCardFactory(CARDTYPE cardtype, int annualCharge)
        {
            _annualCharge = annualCharge;
            _cardtype = cardtype;

        }

        public override CreditCard GetCreditCard()
        {
            return _cardtype switch
            {
                CARDTYPE.BASIC => new Concrete1000CreditCard(_annualCharge),
                CARDTYPE.PLATINUM => new Concrete2000CreditCard(_annualCharge),
                CARDTYPE.GOLD => new Concrete3000CreditCard(_annualCharge),
                _ => null
            };
        }
    }


}
