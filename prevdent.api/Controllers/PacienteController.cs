using Microsoft.AspNetCore.Mvc;
using prevdent.application.Factories.Interfaces;
using prevdent.application.Services.Interfaces;
using PrevDent.Appllication.Dtos;
using PrevDent.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace PrevDent.Presentation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteApplicationService _pacienteApplicationService;
        private readonly IPacienteFactory _pacienteFactory;

        public PacienteController(IPacienteApplicationService pacienteApplicationService, IPacienteFactory pacienteFactory)
        {
            _pacienteApplicationService = pacienteApplicationService;
            _pacienteFactory = pacienteFactory;
        }

        [HttpGet]
        [Produces(typeof(IEnumerable<PacienteEntity>))]
        [SwaggerOperation(Summary = "Obter todos os pacientes", Description = "Retorna uma lista de todos os pacientes.")]
        [SwaggerResponse(200, "Lista de pacientes obtida com sucesso", typeof(IEnumerable<PacienteEntity>))]
        [SwaggerResponse(204, "Nenhum paciente encontrado")]
        [SwaggerResponse(400, "Erro ao obter pacientes")]
        public IActionResult Get()
        {
            try
            {
                var pacientes = _pacienteApplicationService.ObterTodoPacientes();

                if (pacientes is null)
                    return NoContent();

                return Ok(pacientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(PacienteEntity))]
        [SwaggerOperation(Summary = "Obter paciente por ID", Description = "Retorna um paciente pelo ID.")]
        [SwaggerResponse(200, "Paciente obtido com sucesso", typeof(PacienteEntity))]
        [SwaggerResponse(204, "Paciente não encontrado")]
        [SwaggerResponse(400, "Erro ao obter paciente")]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var paciente = _pacienteApplicationService.ObterPacientePorId(id);

                if (paciente is null)
                    return NoContent();

                return Ok(paciente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Produces(typeof(PacienteEntity))]
        [SwaggerOperation(Summary = "Criar novo paciente", Description = "Cria um novo paciente.")]
        [SwaggerResponse(200, "Paciente criado com sucesso", typeof(PacienteEntity))]
        [SwaggerResponse(400, "Erro ao criar paciente")]
        public IActionResult Post([FromBody] PacienteDTO entity)
        {
            try
            {
                var paciente = _pacienteApplicationService.SalvarDadosPacientes(entity);

                return Ok(paciente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        [Produces(typeof(PacienteEntity))]
        [SwaggerOperation(Summary = "Atualizar paciente", Description = "Atualiza os dados de um paciente existente.")]
        [SwaggerResponse(200, "Paciente atualizado com sucesso", typeof(PacienteEntity))]
        [SwaggerResponse(400, "Erro ao atualizar paciente")]
        public IActionResult Put(int id, [FromBody] PacienteDTO entity)
        {
            try
            {
                var paciente = _pacienteApplicationService.EditarDadosPacientes(id, entity);

                return Ok(paciente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        [Produces(typeof(PacienteEntity))]
        [SwaggerOperation(Summary = "Deletar paciente", Description = "Deleta um paciente pelo ID.")]
        [SwaggerResponse(200, "Paciente deletado com sucesso", typeof(PacienteEntity))]
        [SwaggerResponse(400, "Erro ao deletar paciente")]
        public IActionResult Delete(int id)
        {
            try
            {
                var paciente = _pacienteApplicationService.DeletarDadosPacientes(id);

                return Ok(paciente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
