using System;
using Patterns.Factory;
using Patterns.Singleton;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton

            //https://www.c-sharpcorner.com/article/factory-method-design-pattern-in-c-sharp/

            SingletonThreadSafeBasic s1 = SingletonThreadSafeBasic.Instance;
            SingletonThreadSafeBasic s2 = SingletonThreadSafeBasic.Instance;

            Console.WriteLine($"SingletonThreadSafeBasic 1 Hash: {s1.GetHashCode()}");
            Console.WriteLine($"SingletonThreadSafeBasic 2 Hash: {s2.GetHashCode()}");

            Console.WriteLine($"SingletonThreadSafeBasic 1 and 2 Equal Types: {s1.GetType() == s2.GetType()}");

            SingletonThreadSafeAdvanced sa1 = SingletonThreadSafeAdvanced.Instance;
            SingletonThreadSafeAdvanced sa2 = SingletonThreadSafeAdvanced.Instance;

            Console.WriteLine($"SingletonThreadSafeAdvanced 1 Hash: {sa1.GetHashCode()}");
            Console.WriteLine($"SingletonThreadSafeAdvanced 2 Hash: {sa2.GetHashCode()}");

            Console.WriteLine($"SingletonThreadSafeAdvanced 1 and 2 Equal Types: {sa1.GetType() == sa2.GetType()}");

            #endregion

            #region Factory

            //https://www.c-sharpcorner.com/article/factory-method-design-pattern-in-c-sharp/

            CardFactory cfBasic = new ConcreteCardFactory(CARDTYPE.BASIC, 5);
            var cfb1 = cfBasic.GetCreditCard();
            var cfb2 = cfBasic.GetCreditCard();
            CardFactory cfPlatinum = new ConcreteCardFactory(CARDTYPE.PLATINUM, 10);
            var cfp1 = cfPlatinum.GetCreditCard();
            var cfp2 = cfPlatinum.GetCreditCard();
            CardFactory cfGold = new ConcreteCardFactory(CARDTYPE.GOLD, 15);
            var cfg1 = cfGold.GetCreditCard();
            var cfg2 = cfGold.GetCreditCard();


            Console.WriteLine($"cfb1 Hash: {cfb1.GetHashCode()} [{cfb1.CardType}] [{cfb1.AnnualCharge}] [{cfb1.CreditLimit}]");
            Console.WriteLine($"cfb2 Hash: {cfb2.GetHashCode()} [{cfb2.CardType}] [{cfb2.AnnualCharge}] [{cfb2.CreditLimit}]");

            Console.WriteLine($"cfp1 Hash: {cfp1.GetHashCode()} [{cfp1.CardType}] [{cfp1.AnnualCharge}] [{cfp1.CreditLimit}]");
            Console.WriteLine($"cfp2 Hash: {cfp2.GetHashCode()} [{cfp2.CardType}] [{cfp2.AnnualCharge}] [{cfp2.CreditLimit}]");

            Console.WriteLine($"cfg1 Hash: {cfg1.GetHashCode()} [{cfg1.CardType}] [{cfg1.AnnualCharge}] [{cfg1.CreditLimit}]");
            Console.WriteLine($"cfg2 Hash: {cfg2.GetHashCode()} [{cfg2.CardType}] [{cfg2.AnnualCharge}] [{cfg2.CreditLimit}]");

            Console.WriteLine($"cfb 1 and 2 Equal Types: {cfb1.GetType() == cfb2.GetType()}");
            Console.WriteLine($"cfp 1 and 2 Equal Types: {cfp1.GetType() == cfp2.GetType()}");
            Console.WriteLine($"cfg 1 and 2 Equal Types: {cfg1.GetType() == cfg2.GetType()}");


            #endregion


            Console.ReadLine();
        }
    }
}
