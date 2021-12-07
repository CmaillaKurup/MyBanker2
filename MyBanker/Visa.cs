using System;
using System.Data;

namespace MyBanker
{
    public class Visa : Card
    {
        public int preFix { get; }
        private DateTime expiryDate { get; }

        public Visa()
        {
            preFix = 4;
            base.GenerateCardNumber(15);
            expiryDate = DateTime.Now.AddYears(5);
        }
    }
}