namespace DesignPatterns.CreationalPatternsForms
{
    public partial class AbstractFactory : Form
    {
        private Dictionary<string, Type> SOList { get; set;}
        public AbstractFactory()
        {
            InitializeComponent();
            SOList = new Dictionary<string, Type>()
            {
                { "Android", typeof(GUIAndroidCreator) },
                { "IOS", typeof(GUIIosCreator) }
            };
            this.cmbSO.DataSource = this.SOList.Keys.ToList();
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            IGUIAbstractFactory creator = (IGUIAbstractFactory)Activator.CreateInstance(SOList[this.cmbSO.SelectedValue.ToString()]);
            IGUIButton button = creator.CreateButton();
            IGUIForm form = creator.CreateForm();
            string html = form.GetFormWithButton(button);
            wb_ui.DocumentText = html;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            wb_ui.DocumentText = String.Empty;
        }
    }
}
