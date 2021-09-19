using System;
using System.Globalization;
using System.Text;

namespace Aula200HerdarVsCumprirContrato.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"Circle color = {Color}, ");
            str.Append($"radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}, ");
            str.Append($"area = {Area().ToString("F2", CultureInfo.InvariantCulture)}");

            return str.ToString();
        }
    }
}
