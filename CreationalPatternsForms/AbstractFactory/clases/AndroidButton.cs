namespace DesignPatterns.CreationalPatternsForms
{
    public class AndroidButton : IGUIButton
    {
        public string EventOnClick()
        {
            return "console.log('Hola Mundo')";
        }

        public string Style()
        {
            return "red";
        }
    }
}
