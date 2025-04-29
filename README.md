1. Purpose
Model real world situations with object-oriented programming

2. Assignment
This is a mandatory assignment. Finish it by Friday latest. Share your code
to GitHub and send the URL to me in chat. Do it by Friday lunch the latest.
Your solution should have three classes – Money, CurrencyConverter and
Account.

Money should have two properties – a decimal Amount and an enum
Currency. The possibility to make new money should be restricted to a
constructor that takes values for the two properties as parameters.
Changing the Currency enum should only be possible through a method
that uses a CurrencyConverter that it takes as a parameter along the new
currency choice. The method should convert the Amount value.

The enum should look like this and be placed in a separate document:

public enum Currency
{
 Dollar,
 Euro,
 SEK
}

CurrencyConverter should have three properties – decimal Dollar, Euro and
SEK. A new CurrencyConverter should only be possible to make with a
constructor that takes the three values as parameters. Once made, you
should not be able to change the decimal values. You would have to make
a new CurrencyConverter instead. Consider these amounts for the three
decimal values (you can choose more up to date.)
1 SEK
0.085 Euro
0.095 Dollar

Make methods for each type or conversion – Dollar to SEK, Euro to Dollar,
SEK to Dollar and so forth. Each method should take a decimal value to be
converted as parameter and return a decimal value for the converted
value.

Account should have two properties – a Balance of type Money and an int
Id. The Account doesn’t have any explicit constructor or any methods. Just
two properties. 
