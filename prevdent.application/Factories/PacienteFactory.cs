using prevdent.application.Factories.Interfaces;
using PrevDent.Appllication.Dtos;

namespace prevdent.application.Factories
{
    public class PacienteFactory : IPacienteFactory
    {
        public PacienteDTO CreatePaciente(string nome, int idade, string email)
        {
            return new PacienteDTO
            {
                Nome = nome,
                Idade = idade,
                Email = email,
            };
        }
    }
}
