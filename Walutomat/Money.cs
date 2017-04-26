using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walutomat
{
    
    public class Money
    {
        protected int amount;
        protected string currency;
        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }



        public void add(int addent)
        {
            this.amount += addent;
        }

        public void times(int multiplier)
        {
            this.amount *= multiplier;
        }

        public override bool Equals(object object_)
        {
            Money m = (Money)object_;
            return m.amount == this.amount && m.currency == this.currency;
        }

        
    }
}
