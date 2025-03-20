using prevdent.domain.Entities;
using prevdent.infraestructure.Data.Repository.Interfaces;
using PrevDent.Domain.Entities;
using PrevDent.Infrastructure.Data.AppData;

namespace prevdent.infraestructure.Data.Repository;

public class DentistaRepository : IDentistaRepository
{
    private readonly ApplicationContext _context;

    public DentistaRepository(ApplicationContext context)
    {
        _context = context;
    }

    public DentistaEntity? DeletarDados(int id)
    {
        try
        {
            var dentista = _context.Dentista.Find(id);
            if (dentista != null)
            {
                _context.Dentista.Remove(dentista);
                _context.SaveChanges();
                return dentista;
            }
            else
            {
                throw new Exception("Não foi possivel localizar o dentista");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }

    public DentistaEntity? EditarDados(int id, DentistaEntity entity)
    {
        try
        {
            var dentista = _context.Set<DentistaEntity>().Find(id);

            if (dentista is not null)
            {
                dentista.idade = entity.idade;
                dentista.email = entity.email;
                dentista.nome = entity.nome;
                dentista.cro = entity.cro;

                _context.Update(dentista);
                _context.SaveChanges();

                return dentista;
            }
            else
            {

                throw new Exception("Não foi possivel localizar o dentista ");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }

    public DentistaEntity? ObterPorId(int id)
    {
        try
        {
            var dentista = _context.Dentista.Find(id);

            if (dentista is not null)
            {
                return dentista;
            }
            else
            {
                throw new Exception("Não foi possivel localizar o dentista");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }

    public IEnumerable<DentistaEntity>? ObterTodos()
    {
        var dentistas = _context.Dentista.ToList();

        if (dentistas.Any())
            return dentistas;

        return null;
    }

    public DentistaEntity? SalvarDados(DentistaEntity entity)
    {
        try
        {
            _context.Dentista.Add(entity);
            _context.SaveChanges();
            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }
}