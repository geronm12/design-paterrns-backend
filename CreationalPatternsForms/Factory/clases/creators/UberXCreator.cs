namespace DesignPatterns.CreationalPatternsForms
{
    public class UberXCreator : FactoryCreator
    {
        public override IUberFactory Create()
        {
            return new UberX();
        }
    }
}
