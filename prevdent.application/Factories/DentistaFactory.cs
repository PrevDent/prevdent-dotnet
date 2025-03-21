using prevdent.application.Dtos;
using prevdent.application.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prevdent.application.Factories
{
    public class DentistaFactory : IDentistaFactory
    {
        public DentistaDTO CreateDentista(string nome, int idade, string email, string cro)
        {
            return new DentistaDTO
            {
                Nome = nome,
                Idade = idade,
                Email = email,
                Cro = cro
            };
        }
    }
}
