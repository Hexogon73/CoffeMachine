﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class SystemReceiptBanknotes : MoneyReceiver
    {
        public int AddMoney(Banknote banknotes)
        {
            sum += banknotes.Val;
            return sum;
        }
    }
}
