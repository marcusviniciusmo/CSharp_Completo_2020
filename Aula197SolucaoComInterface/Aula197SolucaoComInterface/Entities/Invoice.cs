using System.Globalization;
using System.Text;

namespace Aula197SolucaoComInterface.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}");
            str.AppendLine($"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}");
            str.AppendLine($"Total payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}");

            return str.ToString();
        }
    }
}
