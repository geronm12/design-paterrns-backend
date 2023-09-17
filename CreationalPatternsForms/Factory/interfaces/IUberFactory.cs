namespace DesignPatterns.CreationalPatternsForms
{
    public interface IUberFactory
    {
        public decimal ServiceFee { get; }
        public decimal CalculateServiceFee(decimal miles);
    }
}
