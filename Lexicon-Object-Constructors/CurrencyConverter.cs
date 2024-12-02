using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Object_Constructors
{
    internal class CurrencyConverter
    {
        #region Static CurrencyConverter
        /*
        static decimal sekMult = 1m;
        static decimal eurMult = 10m;
        static decimal usdMult = 9m;
        */
        /* Constructor
        public CurrencyConverter(decimal sek, decimal eur, decimal usd)
        {
            sekMult = sek;
            eurMult = eur;
            usdMult = usd;
        }
        */
        /*
        static decimal MakeAbsolute(decimal input, Currency currency)
        {
            switch (currency)
            {
                case Currency.SEK:
                    return input;

                case Currency.EUR:
                    return input * eurMult;

                case Currency.USD:
                    return input * usdMult;

                default:
                    return input;
            }
        }

        public static class Convert
        {

            public class SEK
            {
                public static decimal ToEUR(decimal amount)
                {
                    decimal valOut = MakeAbsolute(amount, Currency.SEK);
                    return valOut * eurMult;
                }
                public static decimal ToUSD(decimal amount)
                {
                    decimal valOut = MakeAbsolute(amount, Currency.SEK);
                    return valOut * usdMult;
                }
            }
            public static class EUR
            {
                public static decimal ToSEK(decimal amount)
                {
                    decimal valOut = MakeAbsolute(amount, Currency.USD);
                    return valOut * eurMult;
                }
                public static decimal ToUSD(decimal amount)
                {
                    decimal valOut = MakeAbsolute(amount, Currency.USD);
                    return valOut * eurMult;
                }
            }
            public static class USD
            {
                public static decimal ToSEK(decimal amount)
                {
                    decimal valOut = MakeAbsolute(amount, Currency.USD);
                    return valOut * eurMult;
                }
                public static decimal ToEUR(decimal amount)
                {
                    decimal valOut = MakeAbsolute(amount, Currency.USD);
                    return valOut * eurMult;
                }
            }
        }
    */
        #endregion

        public decimal sek { get; }
        public decimal eur { get; }
        public decimal usd { get; }

        public CurrencyConverter(decimal sekIn, decimal eurIn, decimal usdIn)
        {
            sek = sekIn;
            eur = eurIn;
            usd = usdIn;
        }

        public decimal Converter(Currency currencyIn, Currency currencyOut, decimal amountIn)
        {
            decimal amountOut = 0;

            switch (currencyIn) // First convert to SEK
            {
                case Currency.SEK:
                    amountOut = amountIn / sek;
                    break;

                case Currency.EUR:
                    amountOut = amountIn / eur;
                    break;

                case Currency.USD:
                    amountOut = amountIn / usd;
                    break;
            }

            switch (currencyOut) // Then convert further
            {
                case Currency.SEK:
                    amountOut = ToSEK(amountOut);
                    break;

                case Currency.EUR:
                    amountOut = ToEUR(amountOut);
                    break;

                case Currency.USD:
                    amountOut = ToUSD(amountOut);
                    break;
            }

            return amountOut;
        }
        decimal ToSEK(decimal amountIn)
        {
            return amountIn * sek;
        }
        decimal ToEUR(decimal amountIn)
        {
            return amountIn * eur;
        }
        decimal ToUSD(decimal amountIn)
        {
            return amountIn * usd;
        }
    }
}