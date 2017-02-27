using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class SystemReceivingCoins : MoneyReceiver
    {
        public override int AddMoney(Money coins)
        {
            sum += coins.Val;
            num += 1;
            return sum;
        }
    }
}
