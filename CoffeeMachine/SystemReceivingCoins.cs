using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class SystemReceivingCoins : MoneyReceiver
    {
        public int AddMoney(Coint coins)
        {
            sum += coins.Val;
            return sum;
        }
    }
}
