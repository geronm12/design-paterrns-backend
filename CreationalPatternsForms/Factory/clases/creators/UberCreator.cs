namespace DesignPatterns.CreationalPatternsForms
{
    public class UberCreator : FactoryCreator
    {
        public override IUberFactory Create()
        {
            return new Uber();
        }
    }
}
