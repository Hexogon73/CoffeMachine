using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class SystemReceiptBanknotes : MoneyReceiver
    {
        public override int AddMoney(Money banknotes) 
        {
            sum += banknotes.Val;
            num += 1;
            return sum;
        }
    }
}
