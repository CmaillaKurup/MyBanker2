using System;

namespace MyBanker
{
    public class Maestro : Card, INonCreditCard
    {
        public int preFix { get; }
        private DateTime expiryDate { get; }

        public Maestro()
        {
            preFix = GetPreFix();
            base.GenerateCardNumber(12);
            expiryDate = DateTime.Now.AddYears(5).AddMonths(8);
        }

        public int GetPreFix()
        {
            int[] fix = {5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763};
            
            Random rnd = new Random();

            return fix[rnd.Next()];
        }
        
        public int Limit()
        {
            return 0;
        }
    }
}