using PrevDent.Domain.Entities;
using PrevDent.Domain.Interfaces;
using PrevDent.Infrastructure.Data.AppData;

namespace PrevDent.Infrastructure.Data.Repository
{
    public class PacienteRepository : IPacienteRepository
    {

        private readonly ApplicationContext _context;

        public PacienteRepository(ApplicationContext context)
        {
            _context = context;
        }

        public PacienteEntity? DeletarDados(int id)
        {
            try
            {
                var paciente = _context.Paciente.Find(id);

                if (paciente is not null)
                {
                    _context.Remove(paciente);
                    _context.SaveChanges();

                    return paciente;
                }

                //Gera um excecão para informar que nao foi possivel localizar o paciente
                throw new Exception("Não foi possivel localizar o paciente ");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public PacienteEntity? EditarDados(PacienteEntity entity)
        {
            try
            {
                var paciente = _context.Paciente.Find(entity.id_paciente);

                if (paciente is not null)
                {
                    paciente.idade = entity.idade;
                    paciente.email = entity.email;
                    paciente.nome = entity.nome;

                    _context.Update(paciente);
                    _context.SaveChanges();

                    return paciente;
                }

                //Gera um excecão para informar que nao foi possivel localizar o paciente
                throw new Exception("Não foi possivel localizar o paciente ");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public PacienteEntity? ObterPorId(int id)
        {
            var paciente = _context.Paciente.Find(id);

            if (paciente is not null)
            {
                return paciente;
            }
            return null;
        }

        public IEnumerable<PacienteEntity>? ObterTodos()
        {
            var pacientes = _context.Paciente.ToList();

            if (pacientes.Any())
                return pacientes;

            return null;
        }

        public PacienteEntity? SalvarDados(PacienteEntity entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possivel salvar o paciente ");
            }

        }
    }

}
