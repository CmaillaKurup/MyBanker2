using System;

namespace MyBanker
{
    public class Mastercard : Card, INonCreditCard
    {
        public int preFix { get; }
        private DateTime expiryDate { get; }

        public Mastercard()
        {
            preFix = GetPreFix();
            base.GenerateCardNumber(14);
            expiryDate = DateTime.Now.AddYears(5);
        }
        
        public int GetPreFix()
        {
            int[] fix = {51, 52, 53, 54, 55};
            
            Random rnd = new Random();

            return fix[rnd.Next()];
        }
        
        public int Limit()
        {
            return 0;
        }
    }
}