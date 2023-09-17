namespace DesignPatterns.CreationalPatternsForms
{
    public class CarBuilderDirector
    {
        private readonly ICarBuilder CarBuilder;
        public CarBuilderDirector(ICarBuilder carBuilder)
        {
            CarBuilder = carBuilder;    
        }

        public CustomCar GetBasicCar(CarTypes carType, Color carColor, string? domain, Engine engineType, bool braces, bool snowBraces, int airbags, bool alarm, bool automaticGlass)
        {
            return CarBuilder.AddType(carType)
                             .AddColor(carColor)
                             .AddEngine(engineType)
                             .AddBraces(braces)
                             .AddSnowBraces(snowBraces)
                             .AddAirBags(airbags)
                             .AddAutomaticGlass(automaticGlass)
                             .AddAlarm(alarm)
                             .GetCar();
        }

        public CustomCar GetCustomCar(CarTypes carType, Color carColor, string? domain, Engine engineType, bool braces, bool snowBraces, int airbags, bool alarm, bool automaticGlass, bool polarized, int polarizedDegree)
        {
            return CarBuilder.AddType(carType)
                            .AddColor(carColor)
                            .AddEngine(engineType)
                            .AddBraces(braces)
                            .AddSnowBraces(snowBraces)
                            .AddAirBags(airbags)
                            .AddAutomaticGlass(automaticGlass)
                            .AddAlarm(alarm)
                            .AddPolarized(polarized, polarizedDegree)
                            .GetCar();
        }
    }
}
