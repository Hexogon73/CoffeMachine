using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class PaymentSystem
    {
        public void PayOrder(int order_cost, MoneyReceiver mr) {
            int residue;
            if (mr.sum >= order_cost)
            {
                residue = mr.sum - order_cost;
                Console.WriteLine("Оставшиеся сумма: {0}", residue);
            }
            else {
                Console.WriteLine("Внесенной суммы:{0} не хватает на оплату заказа", mr.sum);
            }  
        }
    }
}
