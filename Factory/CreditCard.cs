using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Factory
{
    abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; }
        public abstract int AnnualCharge { get; set; }
    }
}
