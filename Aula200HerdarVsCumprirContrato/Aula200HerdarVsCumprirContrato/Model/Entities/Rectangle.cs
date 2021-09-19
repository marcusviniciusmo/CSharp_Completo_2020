using System.Globalization;
using System.Text;

namespace Aula200HerdarVsCumprirContrato.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"Rectangle color = {Color}, ");
            str.Append($"width = {Width.ToString("F2", CultureInfo.InvariantCulture)}, ");
            str.Append($"height = {Height.ToString("F2", CultureInfo.InvariantCulture)}, ");
            str.Append($"area = {Area().ToString("F2", CultureInfo.InvariantCulture)}");

            return str.ToString();
        }
    }
}
