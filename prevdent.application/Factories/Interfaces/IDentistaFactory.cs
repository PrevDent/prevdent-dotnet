using prevdent.application.Dtos;

namespace prevdent.application.Factories.Interfaces
{
    public interface IDentistaFactory
    {
        DentistaDTO CreateDentista(string nome, int idade, string email, string cro);
    }
}