namespace DesignPatterns.CreationalPatternsForms
{
    public class GUIIosCreator : IGUIAbstractFactory
    {
        public IGUIButton CreateButton()
        {
            return new IosButton();
        }

        public IGUIForm CreateForm()
        {
            return new IosForm();
        }
    }
}
