using Microsoft.AspNetCore.Mvc;
using prevdent.application.Services.Interfaces;
using PrevDent.Appllication.Dtos;
using PrevDent.Domain.Entities;

namespace PrevDent.Presentation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteApplicationService _pacienteApplicationService;

        public PacienteController(IPacienteApplicationService pacienteApplicationService)
        {
            _pacienteApplicationService = pacienteApplicationService;
        }

        [HttpGet]
        [Produces(typeof(IEnumerable<PacienteEntity>))]
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
        public IActionResult Post([FromBody] PacienteDto entity)
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
        public IActionResult Put(int id, [FromBody] PacienteDto entity)
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
