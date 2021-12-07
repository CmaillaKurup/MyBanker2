using System;

namespace MyBanker
{
    class Program
    {
        static void Main()
        {
            //Created a card
            DebitCard Jonas = new DebitCard();

            //created an account
            Account JonasAccount = new Account("Jonas");
            
            //added the card to the account
            JonasAccount.AddCard(Jonas);

            Console.WriteLine("Card Number: " + Jonas.preFix + Jonas.number);
        }
    }
}