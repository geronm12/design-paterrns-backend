namespace DesignPatterns.StructuralPatterns
{
    public partial class Decorator : Form
    {
        private static List<Milk> milks { get; set; }
        private static List<string> decorators = new List<string>()
        {
            "Entera",
            "Descremada",
            "Deslactosada"
        };

        public Decorator(
            )
        {
            InitializeComponent();
            milks = new List<Milk>();
            cmbLeche.DataSource = decorators;
            dgvLeche.DataSource = milks;
        }
 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (cmbLeche.SelectedValue)
            {
                case "Entera":
                    MilkProcess process = new MilkProcess();
                    var lecheEntera = process.ProcessMilk();
                    milks.Add(new Milk()
                    {
                        Cremosidad = lecheEntera.Item1,
                        CH = lecheEntera.Item3,
                        Grasa = lecheEntera.Item2,
                        Lactosa = lecheEntera.Item3,
                        typeOfMilk = lecheEntera.Item5

                    });
                    break;
                case "Descremada":
                    MilkProcess processDesc = new MilkProcess();
                    MilkDescremadaDecorator decoratorDesc = new MilkDescremadaDecorator(processDesc);
                    var lecheDescremada = decoratorDesc.ProcessMilk();
                    milks.Add(new Milk()
                    {
                        Cremosidad = lecheDescremada.Item1,
                        CH = lecheDescremada.Item3,
                        Grasa = lecheDescremada.Item2,
                        Lactosa = lecheDescremada.Item3,
                        typeOfMilk = lecheDescremada.Item5

                    });
                    break;
                case "Deslactosada":
                    MilkProcess processDesl = new MilkProcess();
                    MilkDescremadaDecorator decoratorDesla = new MilkDescremadaDecorator(processDesl);
                    MilkDeslactozadaDecorator decoratorDesl = new MilkDeslactozadaDecorator(decoratorDesla);
                    var lecheDeslactozada = decoratorDesl.ProcessMilk();
                    milks.Add(new Milk()
                    {
                        Cremosidad = lecheDeslactozada.Item1,
                        CH = lecheDeslactozada.Item3,
                        Grasa = lecheDeslactozada.Item2,
                        Lactosa = lecheDeslactozada.Item3,
                        typeOfMilk = lecheDeslactozada.Item5
                    });
                    break;
                default:
                    break;
            }

            this.dgvLeche.DataSource = null;
            this.dgvLeche.DataSource = milks;
        }


        internal class Milk
        {
            public decimal Grasa { get; set; }
            public decimal Cremosidad { get; set; }
            public decimal CH { get; set; }
            public decimal Lactosa { get; set; }
            public MilkStates typeOfMilk { get; set; }
        }

        private void dgvLeche_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
        }

        private void dgvLeche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
        }

        private void dgvLeche_Click(object sender, EventArgs e)
        {
           
        }
    }
}
