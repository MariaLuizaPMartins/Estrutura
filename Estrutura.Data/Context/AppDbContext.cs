using Estrutura.Data.Mappings;
using Estrutura.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace Estrutura.Data.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var caminhoBd = Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), "Users/maria/Estudo/Database");

            if (!Directory.Exists(caminhoBd))
            {
                Directory.CreateDirectory(caminhoBd);
            }

            optionsBuilder.UseSqlite(@$"Data Source={caminhoBd}\estudo_estrutura.db");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CorMapping());
            modelBuilder.ApplyConfiguration(new OperacaoMapping());
            modelBuilder.ApplyConfiguration(new TamanhoMapping());
        }

        public DbSet<Cor> Cor { get; set; }
        public DbSet<Operacao> Operacao { get; set; }
        public DbSet<Tamanho> Tamanho { get; set; }
    }
}
