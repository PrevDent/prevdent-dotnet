using Moq;
using prevdent.domain.Entities;
using prevdent.infraestructure.Data.Repository.Interfaces;

namespace PrevDent.Tests.Repositories;

public class DentistaRepositoryTest
{
    private readonly Mock<IDentistaRepository> _mockRepository;

    public DentistaRepositoryTest()
    {
        _mockRepository = new Mock<IDentistaRepository>();
    }

    [Fact]
    public void ShouldGetAllDentistas()
    {
        var dentistas = new List<DentistaEntity>
        {
            new DentistaEntity
            {
                id_dentista = 1,
                nome = "João Silva",
                idade = 35,
                email = "joao@email.com",
                cro = "SP123456"
            }
        };

        _mockRepository.Setup(repo => repo.ObterTodos()).Returns(dentistas);

        var result = _mockRepository.Object.ObterTodos();

        Assert.NotNull(result);
        Assert.Single(result);
    }

    [Fact]
    public void ShouldGetDentistaById()
    {
        var dentista = new DentistaEntity
        {
            id_dentista = 1,
            nome = "João Silva",
            idade = 35,
            email = "joao@email.com",
            cro = "SP123456"
        };

        _mockRepository.Setup(repo => repo.ObterPorId(1)).Returns(dentista);

        var result = _mockRepository.Object.ObterPorId(1);

        Assert.NotNull(result);
        Assert.Equal(1, result.id_dentista);
    }

    [Fact]
    public void ShouldAddDentista()
    {
        var dentista = new DentistaEntity
        {
            id_dentista = 1,
            nome = "João Silva",
            idade = 35,
            email = "joao@email.com",
            cro = "SP123456"
        };

        _mockRepository.Setup(repo => repo.SalvarDados(dentista)).Returns(dentista);

        var result = _mockRepository.Object.SalvarDados(dentista);

        Assert.NotNull(result);
        Assert.Equal("João Silva", result.nome);
    }

    [Fact]
    public void ShouldUpdateDentista()
    {
        var dentista = new DentistaEntity
        {
            id_dentista = 1,
            nome = "João Atualizado",
            idade = 40,
            email = "joao@novoemail.com",
            cro = "SP654321"
        };

        _mockRepository.Setup(repo => repo.EditarDados(1, dentista)).Returns(dentista);

        var result = _mockRepository.Object.EditarDados(1, dentista);

        Assert.NotNull(result);
        Assert.Equal("João Atualizado", result.nome);
    }

    [Fact]
    public void ShouldDeleteDentista()
    {
        var dentista = new DentistaEntity
        {
            id_dentista = 1,
            nome = "João Silva",
            idade = 35,
            email = "joao@email.com",
            cro = "SP123456"
        };

        _mockRepository.Setup(repo => repo.DeletarDados(1)).Returns(dentista);

        var result = _mockRepository.Object.DeletarDados(1);

        Assert.NotNull(result);
        Assert.Equal(1, result.id_dentista);
    }
}
