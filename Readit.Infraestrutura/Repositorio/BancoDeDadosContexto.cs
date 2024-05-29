using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Readit.Dominio.Opcoes;
using Readit.Infraestrutura.Entidades;
using Readit.Infraestrutura.Repositorio.ConfiguracoesEntidades;

namespace Readit.Infraestrutura.Repositorio.BancoDeDadosContexto
{
    public class BancoDeDadosContexto : DbContext
    {
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<Curtida> Curtida { get; set; }
        public DbSet<CurtidaAvaliacao> CurtidaAvaliacao { get; set; }
        public DbSet<CurtidaLivro> CurtidaLivro { get; set; }
        public DbSet<HistoricoSenha> HistoricoSenha { get; set; }
        public DbSet<Lista> Lista { get; set; }
        public DbSet<ListasLivros> ListasLivros { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        private readonly string _connectionString;

        public BancoDeDadosContexto(IOptionsMonitor<BancoDeDadosOpcoes> BDOpcoes) => _connectionString = BDOpcoes.CurrentValue.ConnectionString;


        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(_connectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsuarioConfiguracao).Assembly);
    }
}
