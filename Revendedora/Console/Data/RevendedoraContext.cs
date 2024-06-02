using System;
using Microsoft.EntityFrameworkCore;
using Model;

namespace AutoCenter.Data
{
    class AutoCenterContext : DbContext
    {
 
        //pessoas 
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        //compras e vendas
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        //estabelimento e fornecador
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        
        //veiculo modelo
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Modelo> Modelos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //ver os log do efcore
                //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

                string connectionString = "Server=localhost;Database=db_revendedora;User=root;Password=admin;";

                optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 25)));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração das entidades

            // Fornecedora
            modelBuilder.Entity <Fornecedor>()
                .HasKey(pk => pk.ID);


           /* //não pode haver dois caixas com login igual
            modelBuilder.Entity<Caixa>()
                .HasIndex(p => p.Login)
                .IsUnique();

            //uma empresa muitos caixas
            modelBuilder.Entity<Caixa>()
                .HasOne(v => v.Empresa)
                .WithMany(e => e.Caixas)
                .HasForeignKey(v => v.EmpresaId);
           */
           
        }
    }
}