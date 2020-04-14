using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment3
{

    abstract class PaymentMethod
    {
        public abstract bool Pay(decimal amount);
    }

    class CreditCard : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 900)
            {
                Console.WriteLine($"Paying {amount} using Credit Card declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using Credit Card");
                return true;
            }
        }
    }

    class BankTransfer : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 1500)
            {
                Console.WriteLine($"Paying {amount} using BankTransfer declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using BankTransfer");
                return true;
            }
        }
    }

    class Cash : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 500)
            {
                Console.WriteLine($"Paying {amount} using Cash declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using Cash");
                return true;
            }
        }
    }

}
