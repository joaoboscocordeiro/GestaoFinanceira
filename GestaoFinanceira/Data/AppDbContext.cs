using GestaoFinanceira.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoFinanceira.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<TransacaoModel> Transacaos { get; set; }
        public DbSet<FinanceiroModel> Financas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaModel>().HasData(
                    
                    new CategoriaModel { CategoriaId = "educacao", Nome = "Educação"},
                    new CategoriaModel { CategoriaId = "salario", Nome = "Salário"},
                    new CategoriaModel { CategoriaId = "viagem", Nome = "Viagem"},
                    new CategoriaModel { CategoriaId = "mercado", Nome = "Mercado"},
                    new CategoriaModel { CategoriaId = "comissao", Nome = "Comissão"}

                );

            modelBuilder.Entity<TransacaoModel>().HasData(
                
                    new TransacaoModel { TransacaoId = "ganho", Nome = "Ganho"},
                    new TransacaoModel { TransacaoId = "gasto", Nome = "Gasto"}
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
