﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class SystemReceivingCoins : PaymentSystem
    {
        public int SetMoney(Coint coins)
        {
            sum += coins.value;
            return sum;
        }
    }
}
