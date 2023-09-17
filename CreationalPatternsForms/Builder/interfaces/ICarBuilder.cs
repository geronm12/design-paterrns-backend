namespace DesignPatterns.CreationalPatternsForms
{
    public interface ICarBuilder
    {
        CarBuilder AddDomain(string? domain);
        CarBuilder AddEngine(Engine type);

        CarBuilder AddColor(Color color);

        CarBuilder AddType(CarTypes type);

        CarBuilder AddBraces(bool braces);

        CarBuilder AddSnowBraces(bool snowBraces);

        CarBuilder AddAirBags(int airbagsAmount);

        CarBuilder AddAlarm(bool alarm);

        CarBuilder AddAutomaticGlass(bool automaticGlass);

        CarBuilder AddPolarized(bool polarized, int polarizedDegree);

        CustomCar GetCar();
    }
}
