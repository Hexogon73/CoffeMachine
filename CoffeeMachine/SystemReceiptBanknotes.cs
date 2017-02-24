using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class SystemReceiptBanknotes : PaymentSystem
    {
        public int SetMoney(Banknote banknotes)
        {
            sum += banknotes.value;
            return sum;
        }
    }
}
