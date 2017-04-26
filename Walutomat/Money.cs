using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walutomat
{
    
    public class Money
    {
        private int amount;
        private string currency;
        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public void Add(int addent)
        {
            this.amount += addent;
        }

        public void Times(int multiplier)
        {
            this.amount *= multiplier;
        }

        public override bool Equals(object o)
        {
            Money m = (Money)o;
            return m.amount == this.amount && m.currency == this.currency;
        }

        
    }
}
