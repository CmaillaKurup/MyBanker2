using System;
using System.Collections.Generic;

namespace MyBanker
{
    public class Account
    {
        private string accountNumber { get; set; }
        private string name { get; }
        private List<Card> cards { get; }


        public Account(string name)
        {
            this.name = name;
            this.cards = new List<Card>();
            GenerateAccountNumber();
        }

        //Generating account number by random
        private void GenerateAccountNumber()
        {
            Random rnd = new Random();
            
            string genNum = "";
            string regNum = "3520";

            for (int i = 0; i < 10; i++)
            {
                genNum = genNum + rnd.Next(0, 9);
            }

            accountNumber = regNum + genNum;
        }
        
        //adding cards
        public void AddCard( Card card)
        {
            card.accountNumber = accountNumber;
            
            cards.Add(card);
        }
    }
}