﻿using System;

namespace Hole4
{
    public class Money
    {
        public readonly int value;
        public readonly String currency;

        private Money(int value, String currency)
        {
            this.value = value;
            this.currency = currency;
        }

        public static Money Create(int value, string currency) {
            return new Money(value, currency);
        }

        public Money Plus(Money other)
        {
            if (!other.currency.Equals(currency))
            {
                throw new Incalculable();
            }

            return Create(value + other.value, other.currency);
        }

        public Money Minus(Money tax) {
            if (!currency.Equals(tax.currency)) {
                throw new Incalculable();
            }

            return Money.Create(value - tax.value, currency);
        }
    }
}