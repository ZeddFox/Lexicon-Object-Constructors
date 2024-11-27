using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Object_Constructors
{
    internal class Money
    {
        private decimal amount;
        private Currency currency;

        public Money(decimal inputAmount, Currency inputCurrency)
        {
            amount = inputAmount;
            currency = inputCurrency;
        }

        public decimal Amount
        {
            get { return amount; }
            private set { amount = value; }
        }
        public Currency Currency
        {
            get { return currency; }
            private set { currency = value; }
        }

        public void Convert(CurrencyConverter currencyConverter, Currency desiredCurrency)
        {
            Amount = currencyConverter.Converter(currency, desiredCurrency, amount);
            Currency = desiredCurrency;
        }

        #region Static CurrencyConverter
        /* 
        public void ConvertCurrency(Currency inputCurrency, decimal InputValue)
        {
            switch (Currency)
            {
                case Currency.SEK:
                    if (inputCurrency == Currency.EUR)
                    {
                        Amount = CurrencyConverter.Convert.SEK.ToEUR(InputValue);
                        Currency = inputCurrency;
                    }
                    else if (inputCurrency == Currency.USD)
                    {
                        Amount = CurrencyConverter.Convert.SEK.ToUSD(InputValue);
                        Currency = inputCurrency;
                    }
                    break;

                case Currency.EUR:
                    if (inputCurrency == Currency.SEK)
                    {
                        Amount = CurrencyConverter.Convert.EUR.ToSEK(InputValue);
                        Currency = inputCurrency;
                    }
                    else if (inputCurrency == Currency.USD)
                    {
                        Amount = CurrencyConverter.Convert.EUR.ToUSD(InputValue);
                        Currency = inputCurrency;
                    }
                    break;

                case Currency.USD:
                    if (inputCurrency == Currency.SEK)
                    {
                        Amount = CurrencyConverter.Convert.USD.ToSEK(InputValue);
                        Currency = inputCurrency;
                    }
                    else if (inputCurrency == Currency.EUR)
                    {
                        Amount = CurrencyConverter.Convert.USD.ToEUR(InputValue);
                        Currency = inputCurrency;
                    }
                    break;

                default:

                    break;
            }
        }
        */
        #endregion
    }
}