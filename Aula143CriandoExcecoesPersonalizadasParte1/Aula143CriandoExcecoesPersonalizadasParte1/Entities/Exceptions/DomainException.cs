using System;

namespace Aula143CriandoExcecoesPersonalizadasParte1.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
