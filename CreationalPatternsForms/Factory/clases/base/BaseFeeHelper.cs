namespace DesignPatterns.CreationalPatternsForms
{
    public class BaseFeeHelper
    {
        private decimal KmRepresentation => 1.609m;


        protected decimal MilesToKm(decimal miles)
        {
            return miles * KmRepresentation;
        }
    }
}
