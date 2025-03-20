using PrevDent.Appllication.Dtos;

namespace prevdent.application.Factories.Interfaces
{
    public interface IPacienteFactory
    {
        PacienteDTO CreatePaciente(string nome, int idade, string email);
    }
}