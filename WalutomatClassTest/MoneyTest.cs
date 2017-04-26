﻿using System;
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
            Assert.AreEqual(m, new Money(2, "USD"));   
  
        }

        [Test]
        public void TestEquality()
        {
            Assert.True(Money.dolar(5).Equals(Money.dolar(5)));
            Assert.False(Money.dolar(5).Equals(Money.dolar(6)));
            Assert.False(Money.franc(5).Equals(Money.dolar(5)));
        }


    }
}
