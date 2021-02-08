using Microsoft.EntityFrameworkCore;
using Zap.Models;

namespace Zap.Database
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }
    }
}
