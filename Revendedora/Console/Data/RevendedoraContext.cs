using System;
using Microsoft.EntityFrameworkCore;
using Model;
using Repository;

namespace Data
{
    class RevendedoraContext : DbContext
    {
        public RevendedoraContext() {}
        
        //---------------------------------------------------------------------------------------------//
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
                //optionsBuilder.LogTo(System.Console.WriteLine); ;

                string connectionString = "Server=localhost;Database=db_revendedora;User=root;Password=admin;";

                optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 25)));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração das chaves primárias
            modelBuilder.Entity<Fornecedor>()
                .HasKey(f => f.ID);
            modelBuilder.Entity<Fornecedor>()
                .Property(f => f.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.ID);
            modelBuilder.Entity<Cliente>()
                .Property(c => c.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Funcionario>()
                .HasKey(f => f.ID);
            modelBuilder.Entity<Funcionario>()
                .Property(f => f.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Compra>()
                .HasKey(c => c.ID);
            modelBuilder.Entity<Compra>()
                .Property(c => c.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Venda>()
                .HasKey(v => v.ID);
            modelBuilder.Entity<Venda>()
                .Property(v => v.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Estabelecimento>()
                .HasKey(e => e.ID);
            modelBuilder.Entity<Estabelecimento>()
                .Property(e => e.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.ID);
            modelBuilder.Entity<Usuario>()
                .Property(u => u.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Veiculo>()
                .HasKey(v => v.ID);
            modelBuilder.Entity<Veiculo>()
                .Property(v => v.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Modelo>()
                .HasKey(m => m.ID);
            modelBuilder.Entity<Modelo>()
                .Property(m => m.ID)
                .ValueGeneratedOnAdd();

            //----------------------------------------------------------------------------------------//

            
            //compra
            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Fornecedor)
                .WithMany(v => v.Compras)  // Fornecedor pode ter muitas Compras (ou especificar coleção se existir)
                .HasForeignKey(c => c.FornecedorID);

            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Funcionario)
                .WithMany(v => v.Compras)  // Fornecedor pode ter muitas Compras (ou especificar coleção se existir)
                .HasForeignKey(c => c.FuncionarioID);

            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Veiculo)
                .WithOne(v => v.Compra)  // Fornecedor pode ter muitas Compras (ou especificar coleção se existir)
                .HasForeignKey<Veiculo>(v => v.CompraID);

            //estabelecimento
            //fornecedor


            //funcionario
            modelBuilder.Entity<Funcionario>()
                .HasOne(c => c.Usuario)
                .WithOne(v => v.Funcionario)  // Fornecedor pode ter muitas Compras (ou especificar coleção se existir)
                .HasForeignKey<Usuario>(v => v.FuncionarioID);

            //modelo


            //usuario
            modelBuilder.Entity<Usuario>()
                .HasOne(c => c.Funcionario)
                .WithOne(v => v.Usuario)  // Fornecedor pode ter muitas Compras (ou especificar coleção se existir)
                .HasForeignKey<Funcionario>(v => v.UsuarioID);

            //veiculo

            modelBuilder.Entity<Veiculo>()
                .HasOne(v => v.Modelo)
                .WithOne()
                .HasForeignKey<Veiculo>(v => v.ModeloID);

            modelBuilder.Entity<Veiculo>()
                .HasOne(v => v.Compra)
                .WithOne(e => e.Veiculo)
                .HasForeignKey<Veiculo>(v => v.CompraID);

            modelBuilder.Entity<Veiculo>()
               .HasOne(v => v.Venda)
               .WithOne(e => e.Veiculo)
               .HasForeignKey<Veiculo>(v => v.VendaID);

            modelBuilder.Entity<Veiculo>()
              .HasOne(v => v.Estabelecimento)
              .WithMany()
              .HasForeignKey(v => v.EstabelecimentoID);

            //modelBuilder.Entity<OrdemDeServico>()
            //    .HasOne(v => v.Vendedor)
            //   .WithMany(c => c.OrdensDeServico) // Define o relacionamento (um-para-muitos)
            //   .HasForeignKey(v => v.VendedorId);


            //venda
            modelBuilder.Entity<Venda>()
              .HasOne(v => v.Veiculo)
              .WithOne(e => e.Venda)
              .HasForeignKey<Veiculo>(v => v.VendaID);

            modelBuilder.Entity<Venda>()
              .HasOne(v => v.Cliente)
              .WithMany(e => e.Vendas)
              .HasForeignKey(v => v.ClienteID);

            modelBuilder.Entity<Venda>()
             .HasOne(v => v.Funcionario)
             .WithMany(e => e.Vendas)
             .HasForeignKey(v => v.FuncionarioID);

       
            // modelBuilder.Entity<Entidade1>()
            //    .HasOne(e1 => e1.Entidade2)
            //    .WithOne(e2 => e2.Entidade1)
            //    .HasForeignKey<Entidade2>(e2 => e2.Entidade1ID); // Chave estrangeira na Entidade2

        }
    }
}