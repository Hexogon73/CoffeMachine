using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class PaymentSystem
    {
        protected int sum;
        protected int num;
        List<Money> mList = new List<Money>();

        public virtual void SetMoney(Money money){
            mList.Add(money);
        }

        public void ShowListMoney() { 
            Console.WriteLine("Список номиналов монет и купюр внесенных покупателем:");
            for (int i = 0; i < mList.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i+1, mList[i].value);
            }
        }

        public void ShowSumMoney(){
            int sum = mList.Sum(x => x.value);
            Console.WriteLine("Сумма номиналов монет и банкнот в системе: {0}", sum);
        }

        public void ShowNumberMoney() {
            foreach (Money m in mList)
            {
                num = mList.Count();
            }
            Console.WriteLine("Количество монет и банкнот в системе: {0}", num);
        }
    }
}
