using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Walutomat;

namespace WalutomatClassTest
{
    [TestFixture]
    public class MoneyTest
    {
        [Test]
        public void AddTest()
        {
            Money m = new Money(2, "USD");
            m.Add(1);
            Assert.AreEqual(m, new Money(2, "USD"));   
  
        }
    }
}
