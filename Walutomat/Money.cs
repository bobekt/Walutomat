using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walutomat
{
    
    public class Money : IExpression
    {
        public int amount;
        protected string currency;
        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money reduce(string to)
        {
            return this;
        }    
    
        public IExpression plus(Money addend)
        {
            return new Sum(this, addend);
        }

        public Money times(int multiplier)
        {
            return new Money(amount*multiplier, currency);
        }

        public override bool Equals(object object_)
        {
            Money m = (Money)object_;
            return m.amount == this.amount && m.currency == this.currency;
        }

        static public Money dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        static public Money franc(int amount)
        {
            return new Money(amount, "CHF");
        }

    }
}
