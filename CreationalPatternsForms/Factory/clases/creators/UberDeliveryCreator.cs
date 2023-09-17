namespace DesignPatterns.CreationalPatternsForms
{
    public class UberDeliveryCreator : FactoryCreator
    {
        public override IUberFactory Create()
        {
            return new UberDelivery();
        }
    }
}
