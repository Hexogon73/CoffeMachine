using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class Banknote : Money
    {
        public Banknote(int _value) {
            value = _value;
        }
    }
}
