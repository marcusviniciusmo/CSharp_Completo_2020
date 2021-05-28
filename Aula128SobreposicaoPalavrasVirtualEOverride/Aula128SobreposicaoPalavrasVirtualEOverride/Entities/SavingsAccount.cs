namespace Aula128SobreposicaoPalavrasVirtualEOverride.Entities
{
    class SavingsAccount : Account
    //sealed class SavingsAccount : Account -- Com o "sealed" não pode ser herdada
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
