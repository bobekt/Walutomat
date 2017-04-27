using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walutomat
{
    public interface IExpression
    {
        Money reduce(string to);
    }
}
