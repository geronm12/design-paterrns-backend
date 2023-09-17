using DesignPatterns.CreationalPatternsForms;

namespace DesignPatterns
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btn_factory_Click(object sender, EventArgs e)
        {
            var factory = new Factory();
            factory.ShowDialog();
        }

        private void btn_abstractFactory_Click(object sender, EventArgs e)
        {
            var abstractFactory = new AbstractFactory();
            abstractFactory.ShowDialog();
        }

        private void btn_builder_Click(object sender, EventArgs e)
        {
            var builder = new Builder();
            builder.ShowDialog();
        }
    }
}
