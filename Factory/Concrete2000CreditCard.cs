using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Factory
{
    class Concrete2000CreditCard : CreditCard
    {
        private readonly string _cardType;
        private readonly int _creditLimit;
        private int _annualCharge;

        public Concrete2000CreditCard(int annualCharge)
        {
            _cardType = "Concrete2000Card";
            _creditLimit = 2000;
            _annualCharge = annualCharge;
        }

        public override string CardType => _cardType;

        public override int CreditLimit => _creditLimit;

        public override int AnnualCharge
        {
            get => _annualCharge;
            set => _annualCharge = value;
        }
    }
}
