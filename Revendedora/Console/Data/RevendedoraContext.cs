using System;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    class RevendedoraContext : DbContext
    {
        // Singleton
        private RevendedoraContext instance = new RevendedoraContext();
        private RevendedoraContext() {}
        public RevendedoraContext AdquirirContexto() => instance;


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
            // Configuração das chaves primárias
            modelBuilder.Entity<Fornecedor>().HasKey(f => f.ID);
            modelBuilder.Entity<Cliente>().HasKey(c => c.ID);
            modelBuilder.Entity<Funcionario>().HasKey(f => f.ID);
            modelBuilder.Entity<Compra>().HasKey(c => c.ID);
            modelBuilder.Entity<Venda>().HasKey(v => v.ID);
            modelBuilder.Entity<Estabelecimento>().HasKey(e => e.ID);
            modelBuilder.Entity<Usuario>().HasKey(u => u.ID);
            modelBuilder.Entity<Veiculo>().HasKey(v => v.ID);
            modelBuilder.Entity<Modelo>().HasKey(m => m.ID);

            // Relações Cliente-Venda
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Vendas)  // Cliente tem muitas Vendas
                .WithOne(v => v.Cliente) // Venda tem um Cliente
                .HasForeignKey(v => v.ID) // Chave estrangeira em Venda
                .OnDelete(DeleteBehavior.Cascade);  // Ação em cascata para delete

            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Fornecedor)
                .WithMany()  // Fornecedor pode ter muitas Compras (ou especificar coleção se existir)
                .HasForeignKey(c => c.ID);
            // Compra relaciona-se com Veiculo, Fornecedor e Funcionario
            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Veiculo)
                .WithMany()
                .HasForeignKey(c => c.ID); // Adicionar VeiculoID em Compra
            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Fornecedor)
                .WithMany()
                .HasForeignKey(c => c.ID); // Adicionar FornecedorID em Compra

            // Relações Funcionario-Venda e Funcionario-Compra
            modelBuilder.Entity<Funcionario>()
                .HasMany(f => f.Vendas)  // Funcionario tem muitas Vendas
                .WithOne(v => v.Funcionario) // Venda tem um Funcionario
                .HasForeignKey(v => v.ID); // Chave estrangeira em Venda
            modelBuilder.Entity<Funcionario>()
                .HasMany(f => f.Compras)  // Funcionario tem muitas Compras
                .WithOne(c => c.Funcionario) // Compra tem um Funcionario
                .HasForeignKey(c => c.ID); // Chave estrangeira em Compra

            // Relações Venda-Veiculo e Compra-Veiculo
            modelBuilder.Entity<Venda>()
                .HasOne(v => v.Veiculo)
                .WithOne(v => v.Venda)
                 .HasForeignKey<Venda>(c => c.ID);  // A chave estrangeira está em Venda, apontando para Veiculo
            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Veiculo)
                .WithMany()  // Veiculo pode estar em muitas Compras (ou especificar coleção se existir)
                .HasForeignKey(c => c.ID);

            // Relações Compra-Fornecedor
            // Configurações de relações
            // Cliente tem muitas Vendas
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Vendas)
                .WithOne() // Assumindo que Venda tem uma propriedade de navegação para Cliente
                .HasForeignKey(v => v.ID); // Adicionar ID em Venda

            // Funcionario tem muitas Vendas e Compras
            modelBuilder.Entity<Funcionario>()
                .HasMany(f => f.Vendas)
                .WithOne()
                .HasForeignKey(v => v.ID); // Adicionar FuncionarioID em Venda

            modelBuilder.Entity<Funcionario>()
                .HasMany(f => f.Compras)
                .WithOne(c => c.Funcionario)
                .HasForeignKey(c => c.ID);

            // Venda tem um Veiculo e Veiculo pode estar em muitas Vendas
            modelBuilder.Entity<Cliente>()
               .HasMany(c => c.Vendas) // Ajuste para a coleção que deve estar disponível em Venda
               .WithOne(v => v.Cliente) // Certifique-se de que existe uma propriedade Cliente em Venda
               .HasForeignKey(v => v.ID); // ClienteID é a chave estrangeira em Venda
            
            // Veiculo tem um Modelo
            modelBuilder.Entity<Veiculo>()
                .HasOne(v => v.Modelo)
                .WithMany() // Assumindo que Modelo não tem uma coleção de Veiculos
                .HasForeignKey(v => v.ID); // Adicionar ModeloID em Veiculo

            
        }
    }
}