using System;
using System.Collections.Generic;
using System.Text;

namespace Business_logic
{
    class Money
    {
        private int money_in_cents;



        public Money(int dollars = 0, int cents = 0)
        {
            money_in_cents = dollars * 100 + cents;
        }


        public int Dollars
        {
            get
            {
                return money_in_cents / 100;
            }
        }

        public int Cents
        {
            get
            {
                return money_in_cents % 100;
            }
        }


        public override string ToString()
        {
            return "$" + Dollars + "." + Math.Abs(Cents);
        }



        public static Money operator +(Money m1, Money m2)
        {
            return new Money(0, m1.money_in_cents + m2.money_in_cents);
        }

        public static Money operator -(Money m1, Money m2)
        {
            return new Money(0, m1.money_in_cents - m2.money_in_cents);
        }

        public static Money operator *(Money m, int x)
        {
            return new Money(0, m.money_in_cents * x);
        }

        public static Money operator /(Money m, int x)
        {
            return new Money(0, m.money_in_cents / x);
        }


        public static bool operator ==(Money m1, Money m2)
        {
            return m1.money_in_cents == m2.money_in_cents;
        }

        public static bool operator !=(Money m1, Money m2)
        {
            return m1.money_in_cents != m2.money_in_cents;
        }


        public static bool operator >(Money m1, Money m2)
        {
            return m1.money_in_cents > m2.money_in_cents;
        }

        public static bool operator <(Money m1, Money m2)
        {
            return m1.money_in_cents < m2.money_in_cents;
        }


        public static bool operator >=(Money m1, Money m2)
        {
            return m1.money_in_cents >= m2.money_in_cents;
        }

        public static bool operator <=(Money m1, Money m2)
        {
            return m1.money_in_cents <= m2.money_in_cents;
        }


        public override int GetHashCode()
        {
            return money_in_cents;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Money))
                return false;
            else
                return this == ((Money)obj);
        }
    }
}
