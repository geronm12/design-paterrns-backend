namespace DesignPatterns.CreationalPatternsForms
{
    public abstract class FactoryCreator
    {
        public abstract IUberFactory Create();


        public decimal CalculateService(decimal miles)
        {
            IUberFactory factory = Create();
            return factory.CalculateServiceFee(miles);
        }
    }
}
