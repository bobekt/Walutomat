using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walutomat
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Money m = new Money(10, "USD");
            m.Times(5);
            m.Add(10);
            m.Times(4);
            m.Times(2);
           


        }


    }
}
