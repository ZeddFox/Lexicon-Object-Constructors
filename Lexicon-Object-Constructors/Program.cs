
namespace Lexicon_Object_Constructors
{
    class Program()
    {
        static void Main()
        {
            CurrencyConverter currencyConverter = new CurrencyConverter(1m, 0.085m, 0.095m);

            Money moneyOne = new Money(125, Currency.SEK);
            Money moneyTwo = new Money(125, Currency.EUR);
            Money moneyThree = new Money(125, Currency.USD);

            Console.WriteLine("Money conversion: Wallet 1 to EUR, Wallet 2 to USD, Wallet 3 to SEK");
            Console.WriteLine("Rates: SEK: " + currencyConverter.sek + " | EUR: " + currencyConverter.eur + " | USD: " + currencyConverter.usd);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("You started with: ");
            Console.WriteLine("Wallet 1: " + moneyOne.Amount + " " + moneyOne.Currency);
            Console.WriteLine("Wallet 2: " + moneyTwo.Amount + " " + moneyTwo.Currency);
            Console.WriteLine("Wallet 3: " + moneyThree.Amount + " " + moneyThree.Currency);
            Console.WriteLine("-----------------------------------");

            moneyOne.Convert(currencyConverter, Currency.EUR);
            moneyTwo.Convert(currencyConverter, Currency.USD);
            moneyThree.Convert(currencyConverter, Currency.SEK);

            Console.WriteLine("You ended up with: ");
            Console.WriteLine("Wallet 1: " + moneyOne.Amount + " " + moneyOne.Currency);
            Console.WriteLine("Wallet 2: " + moneyTwo.Amount + " " + moneyTwo.Currency);
            Console.WriteLine("Wallet 3: " + moneyThree.Amount + " " + moneyThree.Currency);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}