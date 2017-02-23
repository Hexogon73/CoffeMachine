using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class PaymentSystem
    {
        int sum;
        public virtual void SetMoney(int money){
            sum += money;
        }
    }
}
