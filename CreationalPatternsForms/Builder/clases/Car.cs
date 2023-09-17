namespace DesignPatterns.CreationalPatternsForms
{
    public class Car
    {
        public bool AutomaticGlass { get; set; }

        public bool Alarm { get; set; }

        public int CantAirbags { get; set; }

        public bool SnowBraces { get; set; }

        public bool Braces { get; set; }

        public CarTypes Type { get; set; }

        public Color CarColor { get; set; }

        public string? Domain { get; set; }

        public Engine EngineType { get; set; }
    }


    public enum CarTypes
    {
        Sedan,
        HatchBack
    }

    public enum Engine
    {
        Turbo,
        Full,
        Max
    }
}
