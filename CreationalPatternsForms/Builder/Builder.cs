using System.Text.Json;

namespace DesignPatterns.CreationalPatternsForms
{
    public partial class Builder : Form
    {
        private static CarBuilder _builder;
        private static readonly object _lock = new object();
        public static CarBuilder CarBuilder
        {
            get
            {
                if(_builder == null)
                {
                    lock(_lock)
                    {
                        _builder = new CarBuilder();
                        return _builder;
                    }
                }
                return _builder;
            }
            set
            {
                _builder = value;
            }
        }
        public Builder()
        {
            InitializeComponent();
            this.cmbAuto.DataSource = new List<string>()
            {
                "Base",
                "Super"
            };
        }



        public CustomCar CreateCar()
        {
            CarBuilderDirector director = new CarBuilderDirector(CarBuilder);
            var car = default(CustomCar);
            switch (cmbAuto.SelectedValue)
            {
                case "Base":
                    car = director.GetBasicCar(CarTypes.HatchBack, 
                                               Color.BlueViolet, 
                                               "ABC-123",
                                               Engine.Max, 
                                               true,
                                               false,
                                               0,
                                               true,
                                               true);
                    break;

                case "Super":
                    car = director.GetCustomCar(CarTypes.HatchBack,
                                               Color.BlueViolet,
                                               "ABC-123",
                                               Engine.Max,
                                               true,
                                               false,
                                               0,
                                               true,
                                               true,
                                               true,
                                               4);
                    break;
                default:
                    throw new NotImplementedException("the default case is not implemented");
            }



            return car; 

        }

        private void cmbAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

            var t = JsonSerializer.Serialize(this.CreateCar());
            rTextBox.Text = t;
        }
    }
}
