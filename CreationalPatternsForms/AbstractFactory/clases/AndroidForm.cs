namespace DesignPatterns.CreationalPatternsForms
{
    public class AndroidForm : IGUIForm
    {
        private List<string> _inputs;
        public List<string> Inputs { get => _inputs; set => _inputs = value; }


        public AndroidForm()
        {
            Inputs = new List<string>();
        }
 
        public string GetStyle()
        {
            return "red";
        }

        public string GetFormWithButton(IGUIButton collaborator)
        {
            return $"<button style='background-color: {collaborator.Style()}'>TEST</button>";
        }
    }
}
