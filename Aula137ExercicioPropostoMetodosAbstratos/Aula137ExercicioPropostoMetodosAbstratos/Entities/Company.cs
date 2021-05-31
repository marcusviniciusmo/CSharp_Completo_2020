namespace Aula137ExercicioPropostoMetodosAbstratos.Entities
{
    class Company : TaxPayer
    {
        public int Employees { get; set; }

        public Company(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double TaxesPaid()
        {
            double taxesPaid = 0;

            if (Employees > 10)
            {
                taxesPaid += AnualIncome * 0.14;
            }
            else
            {
                taxesPaid += AnualIncome * 0.16;
            }

            return taxesPaid;
        }
    }
}
