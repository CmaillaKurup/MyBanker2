using System;

namespace MyBanker
{
    public class VisaElectron : Card
    {
        public int preFix { get; }
        private DateTime expiryDate { get; }

        public VisaElectron()
        {
            //Due to the possibility of the prefix having difrents amounts of cifres I have
            //to check that amount before I know how many cifres should be generated from
            //the GenerateCardNumber function
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

        //The prefix can be on of 6 posible
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