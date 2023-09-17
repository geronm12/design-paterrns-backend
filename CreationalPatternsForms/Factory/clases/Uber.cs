namespace DesignPatterns.CreationalPatternsForms
{
    public class Uber : BaseFeeHelper, IUberFactory
    {
        public decimal ServiceFee { get => 100; }

        public decimal CalculateServiceFee(decimal miles)
        {
            return ServiceFee * this.MilesToKm(miles);
        }
    }
}
