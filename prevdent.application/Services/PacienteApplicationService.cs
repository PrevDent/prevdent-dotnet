using AutoMapper;
using Microsoft.EntityFrameworkCore;
using prevdent.application.Services.Interfaces;
using PrevDent.Appllication.Dtos;
using PrevDent.Domain.Entities;
using PrevDent.Domain.Interfaces;

namespace PrevDent.Appllication.Services
{
    public class PacienteApplicationService : IPacienteApplicationService
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IMapper _mapper;

        public PacienteApplicationService(IPacienteRepository pacienteRepository, IMapper mapper)
        {
            _pacienteRepository = pacienteRepository;
            _mapper = mapper;
        }

        public PacienteEntity? DeletarDadosPacientes(int id)
        {
            return _pacienteRepository.DeletarDados(id);
        }

        public PacienteEntity? EditarDadosPacientes(int id, PacienteDTO entity)
        {
            var pacienteEntity = _mapper.Map<PacienteEntity>(entity);
            return _pacienteRepository.EditarDados(id, pacienteEntity);
        }

        public PacienteEntity? ObterPacientePorId(int id)
        {
            return _pacienteRepository.ObterPorId(id);
        }

        public IEnumerable<PacienteEntity>? ObterTodoPacientes()
        {
            return _pacienteRepository.ObterTodos();
        }

        public PacienteEntity? SalvarDadosPacientes(PacienteDTO entity)
        {
            var pacienteEntity = _mapper.Map<PacienteEntity>(entity);
            return _pacienteRepository.SalvarDados(pacienteEntity);
        }
    }

}
