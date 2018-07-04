using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using GerenciadorTarefas.Dominio.Entidade;
using System.IO;

namespace GerenciadorTarefas.Infra.Configuracoes
{
    public class Contexto : DbContext
    {
        public IConfigurationRoot Configuration { get; set; }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Tarefa> TAREFAS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>().ToTable("Tarefa");
            modelBuilder.Entity<Tarefa>()
            .HasKey(t => t.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(RetornaUrlConexao());
            }
        }

        public string RetornaUrlConexao()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            string conexao = Configuration.GetConnectionString("DefaultConnectionString");
            return conexao;
        }
    }
}

