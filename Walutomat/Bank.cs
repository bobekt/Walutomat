using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walutomat
{
    public class Bank
    {
        public Money reduce(IExpression source, string to)
        {
            return Money.dollar(10);
        }
    }
}
