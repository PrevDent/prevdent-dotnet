using prevdent.application.Dtos;
using prevdent.domain.Entities;

namespace prevdent.application.Services.Interfaces
{
    public interface IDentistaApplicationService
    {
        DentistaEntity? DeletarDadosDentista(int id);
        DentistaEntity? EditarDadosDentista(int id, DentistaDTO entity);
        DentistaEntity? ObterDentistaPorId(int id);
        IEnumerable<DentistaEntity>? ObterTodosDentistas();
        DentistaEntity? SalvarDadosDentista(DentistaDTO entity);
    }
}