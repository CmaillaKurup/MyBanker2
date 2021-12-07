using System;

namespace MyBanker
{
    public abstract class Card
    {
        public string number;
        public string accountNumber;

        //as the title of the functions says I generetates cardnumbers here
        public void GenerateCardNumber(int cifre)
        {
            Random rnd = new Random();

            string genNum = "";

            for (int i = 0; i < cifre; i++)
            {
                genNum = genNum + rnd.Next(0, 9);
            }

            number = genNum;
        }
    }
}