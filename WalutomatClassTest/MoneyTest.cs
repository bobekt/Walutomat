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
            Assert.AreEqual(m, new Money(2, "USD"));     
        }

        [Test]
        public void AddSimpleAddition()
        {
            Money five = Money.dollar(5);
            IExpression sum = five.plus(five);
            Bank bank = new Bank();
            Money reduced = bank.reduce(sum, "USD");
            Assert.AreEqual(Money.dollar(10), reduced);
        }

        [Test]
        public void TestPlusReturnSum()
        {
            Money five = Money.dollar(5);
            IExpression result = five.plus(five);
            Sum sum = (Sum)result;
            Assert.AreEqual(five, sum.augend);
            Assert.AreEqual(five, sum.addend);
        }

        [Test]
        public void TestReduceSum()
        {
            IExpression sum = new Sum(Money.dollar(3), Money.dollar(4));
            Bank bank = new Bank();
            Money result = bank.reduce(sum, "USD");
            Assert.AreEqual(Money.dollar(7), result);
        }

        [Test]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.reduce(Money.dollar(1), "USD");
            Assert.AreEqual(Money.dollar(1), result);
        }

        [Test]
        public void TestEquality()
        {
            Assert.True(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.False(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.False(Money.franc(5).Equals(Money.dollar(5)));
        }


    }
}
