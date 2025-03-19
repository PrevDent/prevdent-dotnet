using PrevDent.Appllication.Dtos;
using PrevDent.Domain.Entities;

namespace prevdent.application.Services.Interfaces
{
    public interface IPacienteApplicationService
    {
        IEnumerable<PacienteEntity>? ObterTodoPacientes();
        PacienteEntity? ObterPacientePorId(int id);
        PacienteEntity? SalvarDadosPacientes(PacienteDto entity);
        PacienteEntity? EditarDadosPacientes(int id, PacienteDto entity);
        PacienteEntity? DeletarDadosPacientes(int id);
    }
}
