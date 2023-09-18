namespace DesignPatterns.StructuralPatterns 
{
    public interface IMilkProcess
    {
        //Cremosidad Grasas CH Lactosa Estado
        (decimal, decimal, decimal, decimal,MilkStates) ProcessMilk();
    }
 
    public enum MilkStates
    {
        Comun,
        Descremada,
        Pasteurizada,
        UltraPasteurizada,
        Proteina,
        Deslactozada
    }
}
