namespace DesignPatterns.CreationalPatternsForms
{
    public class UberX : BaseFeeHelper, IUberFactory
    {
        public decimal ServiceFee => 150;

        public decimal CalculateServiceFee(decimal miles)
        {
            return this.MilesToKm(miles) * ServiceFee;
        }
    }
}
