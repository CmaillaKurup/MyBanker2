namespace MyBanker
{
    public class DebitCard : Card, INonCreditCard
    { 
        public int preFix { get; }

        public DebitCard()
        {
            preFix = 2400;
            base.GenerateCardNumber(12);
        }
        
        public int Limit()
        {
            return 0;
        }
    }
}