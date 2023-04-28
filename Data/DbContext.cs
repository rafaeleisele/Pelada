using Microsoft.EntityFrameworkCore;

namespace Pelada.Data
{
    public class PeladaContext : DbContext
    {
        public PeladaContext(DbContextOptions<PeladaContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Jogador> jogadores { get; set; }
    }
}
