namespace DesignPatterns.CreationalPatternsForms
{
    public partial class Factory : Form
    {
        private Dictionary<string, Type> _factory { get; set; }  
        public Factory()
        {
            InitializeComponent();
            _factory = new Dictionary<string, Type>()
            {
                { "Uber", typeof(UberCreator)},
                { "UberX", typeof(UberXCreator)},
                { "UberDelivery", typeof(UberDeliveryCreator) }
            };
            this.cmb_uber.DataSource = _factory.Keys.ToList();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                IsNull(cmb_uber.SelectedValue, "El tipo de movilidad es obligatorio.");

                var factoryObject = _factory[cmb_uber.SelectedValue.ToString()];

                IsNull(factoryObject, "El tipo de movilidad seleccionado no es válido.");
                FactoryCreator instance = Activator.CreateInstance(factoryObject) as FactoryCreator;


                IsNull(instance, "No se pudo crear la instancia, probablemente no se encuentre en el diccionario.");
                var resultado = instance.CalculateService(nud_miles.Value);
 
                rtb_result.Text = resultado.ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.cmb_uber.SelectedIndex = 0;
            this.rtb_result.Text = String.Empty;
            this.nud_miles.Value = 0m;
        }

        private void IsNull(object value, string errorMessage)
        {
            if(value == null)
            {
                throw new Exception(errorMessage);
            }
        }
    }
}
