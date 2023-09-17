namespace DesignPatterns.CreationalPatternsForms
{
    public class CarBuilder : ICarBuilder
    {
        private CustomCar Car { get; set; }

        public CarBuilder()
        {
            Reset();
        }

        public CarBuilder AddAirBags(int airbagsAmount)
        {
            Car.CantAirbags = airbagsAmount;
            return this;
        }

        public CarBuilder AddAlarm(bool alarm)
        {
            Car.Alarm = alarm;
            return this;
        }

        public CarBuilder AddAutomaticGlass(bool automaticGlass)
        {
            Car.AutomaticGlass = automaticGlass;
            return this;
        }

        public CarBuilder AddBraces(bool braces)
        {
           Car.Braces = braces;
            return this;
        }

        public CarBuilder AddColor(Color color)
        {
            Car.CarColor = color;
            return this;
        }

        public CarBuilder AddEngine(Engine type)
        {
            Car.EngineType = type;
            return this;
        }

        public CarBuilder AddPolarized(bool polarized, int polarizedDegree)
        {
            Car.Polarized = polarized;
            Car.PolarizedDegree = polarizedDegree;
            return this;
        }

        public CarBuilder AddSnowBraces(bool snowBraces)
        {
            Car.SnowBraces = snowBraces;
            return this;
        }

        public CarBuilder AddType(CarTypes type)
        {
            Car.Type = type;
            return this;
        }

        public CarBuilder AddDomain(string? domain)
        {
            this.Car.Domain = domain;
            return this;
        }

        public CustomCar GetCar()
        {
            CustomCar tempCar = this.Car;
            this.Reset();
            return tempCar;
        }

        private void Reset()
        {
            Car = new ();
        }

    }
}
