using prevdent.domain.Entities;

namespace prevdent.infraestructure.Data.Repository.Interfaces
{
    public interface IDentistaRepository
    {
        DentistaEntity? DeletarDados(int id);
        DentistaEntity? EditarDados(int id, DentistaEntity entity);
        DentistaEntity? ObterPorId(int id);
        IEnumerable<DentistaEntity>? ObterTodos();
        DentistaEntity? SalvarDados(DentistaEntity entity);
    }
}