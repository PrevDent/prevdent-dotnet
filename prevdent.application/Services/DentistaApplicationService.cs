using AutoMapper;
using prevdent.application.Dtos;
using prevdent.application.Services.Interfaces;
using prevdent.domain.Entities;
using prevdent.infraestructure.Data.Repository.Interfaces;

namespace prevdent.application.Services;

public class DentistaApplicationService : IDentistaApplicationService
{
    private readonly IDentistaRepository _dentistaRepository;
    private readonly IMapper _mapper;

    public DentistaApplicationService(IDentistaRepository dentistaRepository, IMapper mapper)
    {
        _dentistaRepository = dentistaRepository;
        _mapper = mapper;
    }

    public DentistaEntity? DeletarDadosDentista(int id)
    {
        return _dentistaRepository.DeletarDados(id);
    }

    public DentistaEntity? EditarDadosDentista(int id, DentistaDTO entity)
    {
        var dentistaEntity = _mapper.Map<DentistaEntity>(entity);
        return _dentistaRepository.EditarDados(id, dentistaEntity);
    }

    public DentistaEntity? ObterDentistaPorId(int id)
    {
        return _dentistaRepository.ObterPorId(id);
    }

    public IEnumerable<DentistaEntity>? ObterTodosDentistas()
    {
        return _dentistaRepository.ObterTodos();
    }

    public DentistaEntity? SalvarDadosDentista(DentistaDTO entity)
    {
        var dentistaEntity = _mapper.Map<DentistaEntity>(entity);
        return _dentistaRepository.SalvarDados(dentistaEntity);
    }
}
