using System;
using System.Globalization;
using System.Text;

namespace Aula202InterfaceIComparableProblemaMotivador2.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vet = csvEmployee.Split(",");
            Name = vet[0];
            Salary = double.Parse(vet[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"{Name} ");
            str.Append($"{Salary.ToString("F2", CultureInfo.InvariantCulture)}");

            return str.ToString();
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }

            Employee otherEmployee = obj as Employee;

            return Name.CompareTo(otherEmployee.Name);
        }
    }
}
