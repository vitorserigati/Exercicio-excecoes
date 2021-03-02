using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_excecoes.Entitites.Exceptions
{
    class DomainException:ApplicationException
    {
        public DomainException(string message):base(message)
        {

        }
    }
}
