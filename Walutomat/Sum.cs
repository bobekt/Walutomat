using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walutomat
{
    public class Sum : IExpression
    {
        public Money augend;
        public Money addend;

        public Sum(Money augend, Money addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Money reduce(String to)
        {
            int amount = augend.amount + addend.amount;
            return new Money(amount, to);
        }
    }
}
