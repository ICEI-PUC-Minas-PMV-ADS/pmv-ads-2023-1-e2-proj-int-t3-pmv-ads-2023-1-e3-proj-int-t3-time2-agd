using Microsoft.EntityFrameworkCore;

namespace WebAPIAgendAI.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }


    }
}
