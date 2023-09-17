namespace DesignPatterns.CreationalPatternsForms
{
    public class UberDelivery : BaseFeeHelper,IUberFactory
    {
        public decimal ServiceFee => 75;
        private decimal Tip { get; set; }

        public decimal CalculateServiceFee(decimal miles)
        {
            int tipsPerMiles = (int)this.MilesToKm(miles) / 10;

            for (int i = 0; i < tipsPerMiles; i++)
            {
                TipDelivery(2m);
            }

            return miles * ServiceFee + Tip;
        }

        private void TipDelivery(decimal tip)
        {
            Tip += tip;
        }
    }
}
