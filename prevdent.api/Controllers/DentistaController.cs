using Microsoft.AspNetCore.Mvc;
using prevdent.application.Dtos;
using prevdent.application.Services.Interfaces;
using prevdent.domain.Entities;
using PrevDent.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace prevdent.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DentistaController : ControllerBase
{
    private readonly IDentistaApplicationService _dentistaApplicationService;

    public DentistaController(IDentistaApplicationService dentistaApplicationService)
    {
        _dentistaApplicationService = dentistaApplicationService;
    }

    [HttpGet]
    [Produces(typeof(IEnumerable<DentistaDTO>))]
    [SwaggerOperation(Summary = "Obter todos os dentistas", Description = "Retorna uma lista de todos os dentistas.")]
    [SwaggerResponse(200, "Lista de dentistas obtida com sucesso", typeof(IEnumerable<DentistaDTO>))]
    [SwaggerResponse(204, "Nenhum dentista encontrado")]
    [SwaggerResponse(400, "Erro ao obter dentista")]
    public IActionResult Get()
    {
        try
        {
            var pacientes = _dentistaApplicationService.ObterTodosDentistas();

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
    [Produces(typeof(DentistaDTO))]
    [SwaggerOperation(Summary = "Obter dentista por ID", Description = "Retorna um dentista pelo ID.")]
    [SwaggerResponse(200, "Dentista obtido com sucesso", typeof(DentistaDTO))]
    [SwaggerResponse(204, "Dentista não encontrado")]
    [SwaggerResponse(400, "Erro ao obter dentista")]
    public IActionResult ObterPorId(int id)
    {
        try
        {
            var paciente = _dentistaApplicationService.ObterDentistaPorId(id);

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
    [Produces(typeof(DentistaEntity))]
    [SwaggerOperation(Summary = "Salvar dados do dentista", Description = "Salva os dados do dentista.")]
    [SwaggerResponse(200, "Dados do dentista salvos com sucesso", typeof(DentistaEntity))]
    [SwaggerResponse(400, "Erro ao salvar dados do dentista")]
    public IActionResult SalvarDadosDentista(DentistaDTO entity)
    {
        try
        {
            var dentista = _dentistaApplicationService.SalvarDadosDentista(entity);

            return Ok(dentista);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    [Produces(typeof(DentistaDTO))]
    [SwaggerOperation(Summary = "Editar dados do dentista", Description = "Edita os dados do dentista.")]
    [SwaggerResponse(200, "Dados do dentista editados com sucesso", typeof(DentistaDTO))]
    [SwaggerResponse(400, "Erro ao editar dados do dentista")]
    public IActionResult EditarDadosDentista(int id, DentistaDTO entity)
    {
        try
        {
            var dentista = _dentistaApplicationService.EditarDadosDentista(id, entity);

            return Ok(dentista);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    [Produces(typeof(DentistaEntity))]
    [SwaggerOperation(Summary = "Deletar dados do dentista", Description = "Deleta os dados do dentista.")]
    [SwaggerResponse(200, "Dados do dentista deletados com sucesso", typeof(DentistaEntity))]
    [SwaggerResponse(400, "Erro ao deletar dados do dentista")]
    public IActionResult DeletarDadosDentista(int id)
    {
        try
        {
            var dentista = _dentistaApplicationService.DeletarDadosDentista(id);

            return Ok(dentista);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
