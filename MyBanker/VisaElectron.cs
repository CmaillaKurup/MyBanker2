using System;

namespace MyBanker
{
    public class VisaElectron : Card
    {
        public int preFix { get; }
        private DateTime expiryDate { get; }

        public VisaElectron()
        {
            preFix = GetPreFix();
            if (preFix == 4)
            {
                base.GenerateCardNumber(12);
            }

            if (preFix == 6)
            {
                base.GenerateCardNumber(10);
            }
            expiryDate = DateTime.Now.AddYears(5);
        }

        public int GetPreFix()
        {
            int[] fix = {4026, 417500, 4508, 4844, 4913, 4917};
            
            Random rnd = new Random();

            return fix[rnd.Next()];
        }

        public int Limit()
        {
            return 0;
        }
    }
}