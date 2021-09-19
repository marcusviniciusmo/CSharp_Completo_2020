using Aula200HerdarVsCumprirContrato.Model.Enums;

namespace Aula200HerdarVsCumprirContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
