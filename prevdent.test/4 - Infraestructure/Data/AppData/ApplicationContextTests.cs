using Microsoft.EntityFrameworkCore;
using prevdent.domain.Entities;
using PrevDent.Domain.Entities;
using PrevDent.Infrastructure.Data.AppData;

namespace PrevDent.Tests.AppData;

public class ApplicationContextTests
{
    private DbContextOptions<ApplicationContext> GetInMemoryOptions()
    {
        return new DbContextOptionsBuilder<ApplicationContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;
    }

    [Fact]
    public void CanAddAndRetrievePaciente()
    {
        // Arrange
        var options = GetInMemoryOptions();
        using (var context = new ApplicationContext(options))
        {
            var paciente = new PacienteEntity
            {
                nome = "Carlos Teste",
                idade = 32,
                email = "carlos@test.com"
            };

            context.Paciente.Add(paciente);
            context.SaveChanges();
        }

        // Assert
        using (var context = new ApplicationContext(options))
        {
            var paciente = context.Paciente.FirstOrDefault(p => p.email == "carlos@test.com");
            Assert.NotNull(paciente);
            Assert.Equal("Carlos Teste", paciente.nome);
        }
    }

    [Fact]
    public void CanAddAndRetrieveDentista()
    {
        // Arrange
        var options = GetInMemoryOptions();
        using (var context = new ApplicationContext(options))
        {
            var dentista = new DentistaEntity
            {
                nome = "Dra. Ana",
                idade = 45,
                email = "ana@odontologia.com",
                cro = "SP998877"
            };

            context.Dentista.Add(dentista);
            context.SaveChanges();
        }

        // Assert
        using (var context = new ApplicationContext(options))
        {
            var dentista = context.Dentista.FirstOrDefault(d => d.email == "ana@odontologia.com");
            Assert.NotNull(dentista);
            Assert.Equal("Dra. Ana", dentista.nome);
            Assert.Equal("SP998877", dentista.cro);
        }
    }
}
