using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class PaymentSystem
    {
        private int sum_all = 0;
        private int num_all = 0;
        private List<MoneyReceiver> mrList = new List<MoneyReceiver>();

        public void AddReceiver(MoneyReceiver mr)
        {
            mrList.Add(mr);
            sum_all+= mr.CountSum();
            num_all += mr.CountNum();
        }

        public void PayOrder(int order_cost) {
            int residue;
            if (sum_all >= order_cost)
            {
                residue = sum_all - order_cost;
                Console.WriteLine("Оставшиеся сумма: {0}", residue);
            }
            else {
                Console.WriteLine("Внесенной суммы:{0} не хватает на оплату заказа", sum_all);
            }
        }

        /*public void ShowListMoney()
        {
            Console.WriteLine("Список номиналов монет и купюр внесенных покупателем:");
            int i = 0;
            foreach (var v in mrList)
            {
                
                Console.WriteLine("{0}: {1}", i+1, mrList);
            }
        }*/

        public void ShowSumMoney()
        {
            Console.WriteLine("Сумма номиналов монет и банкнот в системе: {0}", sum_all);
        }

        public int ShowNumberMoney()
        {
            Console.WriteLine("Количество монет и банкнот в системе: {0}", num_all);
            return num_all;
        }

        public int GetSum()
        {
            return sum_all;
        }
    }
}
