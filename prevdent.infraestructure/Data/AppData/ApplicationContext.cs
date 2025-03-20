using Microsoft.EntityFrameworkCore;
using prevdent.domain.Entities;
using PrevDent.Domain.Entities;

namespace PrevDent.Infrastructure.Data.AppData
{
    public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
    {
        public DbSet<PacienteEntity> Paciente { get; set; }
        public DbSet<DentistaEntity> Dentista { get; set; }
    }
}
