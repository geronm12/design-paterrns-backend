namespace DesignPatterns.StructuralPatterns
{
    public class MilkProcess : IMilkProcess
    {
        public virtual (decimal, decimal, decimal, decimal, MilkStates) ProcessMilk()
        {
            return (100m, 100m, 100m, 100m, MilkStates.Comun);
        }
    }
}
