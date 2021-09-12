using System;
using System.Globalization;
using System.Text;

namespace Aula199ExercicioDeFixacao.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append(DueDate.ToString("dd/MM/yyyy"));
            str.Append(" - ");
            str.AppendLine(Amount.ToString("F2", CultureInfo.InvariantCulture));

            return str.ToString();
        }
    }
}
