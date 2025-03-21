using PrevDent.Domain.Entities;
using PrevDent.Infrastructure.Data.AppData;

namespace PrevDent.Domain.Interfaces
{
    public interface IPacienteRepository
    {
        IEnumerable<PacienteEntity>? ObterTodos();
        PacienteEntity? ObterPorId(int id);
        PacienteEntity? SalvarDados(PacienteEntity entity);
        PacienteEntity? EditarDados(int id, PacienteEntity entity);
        PacienteEntity? DeletarDados(int id);
    }

}
