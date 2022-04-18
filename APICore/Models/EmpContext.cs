using Microsoft.EntityFrameworkCore;

namespace APICore.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options) : base(options) { }
        DbSet<Empregados> Empregados{ get; set; }
    }
}
