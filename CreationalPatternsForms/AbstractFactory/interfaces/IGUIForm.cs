namespace DesignPatterns.CreationalPatternsForms
{
    public interface IGUIForm
    {
        List<string> Inputs { get; set; }
        string GetStyle();
        string GetFormWithButton(IGUIButton collaborator);
    }
}
