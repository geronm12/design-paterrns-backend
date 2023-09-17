namespace DesignPatterns.CreationalPatternsForms
{
    public class IosForm : IGUIForm
    {
        private List<string> _inputs;
        public List<string> Inputs { get => _inputs; set => _inputs = value; }

        public IosForm()
        {
            Inputs = new List<string>();
        }
        public string GetStyle()
        {
            throw new NotImplementedException();
        }

        public string GetFormWithButton(IGUIButton collaborator)
        {
            return $"<span style='{collaborator.Style()}'>Test IOS</span>";
        }
    }
}
