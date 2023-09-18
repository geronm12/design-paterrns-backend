namespace DesignPatterns.StructuralPatterns
{
    public abstract class MilkDecorator : MilkProcess
    {
        private readonly IMilkProcess _process;
        public MilkDecorator(IMilkProcess process)
        {
            _process = process;
        }

        public override (decimal, decimal, decimal, decimal, MilkStates) ProcessMilk()
        {
            return _process.ProcessMilk();
        }
    }


    public class MilkDescremadaDecorator : MilkDecorator
    {
       
        public MilkDescremadaDecorator(IMilkProcess process)
            : base(process) { }
     
        public override (decimal, decimal, decimal, decimal, MilkStates) ProcessMilk()
        {
            var commonMilk = base.ProcessMilk();
            commonMilk.Item1 -= (commonMilk.Item1 / 3);
            commonMilk.Item2 -= (commonMilk.Item2 / 2);
            commonMilk.Item5 = MilkStates.Descremada;
            return commonMilk;
        }
    }

    public class MilkDeslactozadaDecorator : MilkDecorator
    {
        public MilkDeslactozadaDecorator(IMilkProcess process)
            : base(process) { }


        public override (decimal, decimal, decimal, decimal, MilkStates) ProcessMilk()
        {
            var commonMilk = base.ProcessMilk();
            commonMilk.Item2 -= (commonMilk.Item2 / 2);
            commonMilk.Item4 = 0m;
            commonMilk.Item5 = MilkStates.Deslactozada;
            return commonMilk;
        }

    }
}
