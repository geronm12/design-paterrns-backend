namespace DesignPatterns.CreationalPatternsForms
{
    public interface IGUIAbstractFactory
    {
        IGUIButton CreateButton();
        IGUIForm CreateForm();

    }
}
