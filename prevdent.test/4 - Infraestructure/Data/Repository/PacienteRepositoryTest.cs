using Moq;
using PrevDent.Domain.Entities;
using PrevDent.Domain.Interfaces;

namespace PrevDent.Tests.Repositories;

public class PacienteRepositoryTest
{
    private readonly Mock<IPacienteRepository> _mockRepository;

    public PacienteRepositoryTest()
    {
        _mockRepository = new Mock<IPacienteRepository>();
    }

    [Fact]
    public void ShouldGetAllPacientes()
    {
        var pacientes = new List<PacienteEntity>
        {
            new PacienteEntity
            {
                id_paciente = 1,
                nome = "Maria Oliveira",
                idade = 28,
                email = "maria@email.com"
            }
        };

        _mockRepository.Setup(repo => repo.ObterTodos()).Returns(pacientes);

        var result = _mockRepository.Object.ObterTodos();

        Assert.NotNull(result);
        Assert.Single(result);
    }

    [Fact]
    public void ShouldGetPacienteById()
    {
        var paciente = new PacienteEntity
        {
            id_paciente = 1,
            nome = "Maria Oliveira",
            idade = 28,
            email = "maria@email.com"
        };

        _mockRepository.Setup(repo => repo.ObterPorId(1)).Returns(paciente);

        var result = _mockRepository.Object.ObterPorId(1);

        Assert.NotNull(result);
        Assert.Equal(1, result.id_paciente);
    }

    [Fact]
    public void ShouldAddPaciente()
    {
        var paciente = new PacienteEntity
        {
            id_paciente = 1,
            nome = "Maria Oliveira",
            idade = 28,
            email = "maria@email.com"
        };

        _mockRepository.Setup(repo => repo.SalvarDados(paciente)).Returns(paciente);

        var result = _mockRepository.Object.SalvarDados(paciente);

        Assert.NotNull(result);
        Assert.Equal("Maria Oliveira", result.nome);
    }

    [Fact]
    public void ShouldUpdatePaciente()
    {
        var paciente = new PacienteEntity
        {
            id_paciente = 1,
            nome = "Maria Atualizada",
            idade = 30,
            email = "maria@novoemail.com"
        };

        _mockRepository.Setup(repo => repo.EditarDados(1, paciente)).Returns(paciente);

        var result = _mockRepository.Object.EditarDados(1, paciente);

        Assert.NotNull(result);
        Assert.Equal("Maria Atualizada", result.nome);
    }

    [Fact]
    public void ShouldDeletePaciente()
    {
        var paciente = new PacienteEntity
        {
            id_paciente = 1,
            nome = "Maria Oliveira",
            idade = 28,
            email = "maria@email.com"
        };

        _mockRepository.Setup(repo => repo.DeletarDados(1)).Returns(paciente);

        var result = _mockRepository.Object.DeletarDados(1);

        Assert.NotNull(result);
        Assert.Equal(1, result.id_paciente);
    }
}
