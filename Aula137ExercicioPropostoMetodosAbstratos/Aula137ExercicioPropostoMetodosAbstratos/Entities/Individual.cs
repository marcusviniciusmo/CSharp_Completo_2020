namespace Aula137ExercicioPropostoMetodosAbstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            double taxesPaid = 0;

            if (AnualIncome < 20000)
            {
                taxesPaid += (AnualIncome * 0.16) - (HealthExpenditures * 0.5);
            }
            else
            {
                taxesPaid += (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }

            return taxesPaid;
        }
    }
}
