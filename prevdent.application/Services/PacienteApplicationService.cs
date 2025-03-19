using prevdent.application.Services.Interfaces;
using PrevDent.Appllication.Dtos;
using PrevDent.Domain.Entities;
using PrevDent.Domain.Interfaces;

namespace PrevDent.Appllication.Services
{
    public class PacienteApplicationService : IPacienteApplicationService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteApplicationService(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public PacienteEntity? DeletarDadosCliente(int id) // Specify the full namespace for PacienteEntity
        {
            return _pacienteRepository.DeletarDados(id);
        }

        public PacienteEntity? DeletarDadosPacientes(int id)
        {
            throw new NotImplementedException();
        }

        public PacienteEntity? EditarDadosCliente(int id, PacienteDto entity)
        {
            var Paciente = new PacienteEntity
            {
                id_paciente = id,
                nome = entity.Nome,
                email = entity.Email,
                idade = entity.Idade,
            };

            return _pacienteRepository.EditarDados(Paciente);
        }

        public PacienteEntity? EditarDadosPacientes(int id, PacienteDto entity)
        {
            throw new NotImplementedException();
        }

        public PacienteEntity? ObterPacientePorId(int id)
        {
            return _pacienteRepository.ObterPorId(id);
        }

        public IEnumerable<PacienteEntity>? ObterTodoPacientes()
        {
            return _pacienteRepository.ObterTodos();
        }

        public PacienteEntity? SalvarDadosPacientes(PacienteDto entity)
        {
            var Paciente = new PacienteEntity
            {
                nome = entity.Nome,
                email = entity.Email,
                idade = entity.Idade,
            };

            return _pacienteRepository.SalvarDados(Paciente);
        }
    }

}
