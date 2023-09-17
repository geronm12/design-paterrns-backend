namespace DesignPatterns.CreationalPatternsForms
{
    public class GUIAndroidCreator : IGUIAbstractFactory
    {
        public IGUIButton CreateButton()
        {
            return new AndroidButton();
        }

        public IGUIForm CreateForm()
        {
            return new AndroidForm();
        }
    }
}
