using Microsoft.EntityFrameworkCore;
using PrevDent.Domain.Entities;

namespace PrevDent.Infrastructure.Data.AppData
{
    public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
    {
        public DbSet<PacienteEntity> Paciente { get; set; }
    }
}
