
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_funcionario")]
    internal class Funcionario : Pessoa
    {
        public int? UsuarioID { get; set; }
        public Usuario? Usuario { get; set; }

        public List<Venda> Vendas { get; set; }
        public List<Compra> Compras { get; set; }

        public Funcionario() : base() { }

        public Funcionario(string nome, string cpf, Usuario? usuario) : base(nome, cpf)
        {
            Usuario = usuario;
            Vendas = new List<Venda>();
            Compras = new List<Compra>();
        }

        public Venda RealizarVenda(Veiculo veiculo, Cliente cliente, Decimal valor, DateTime horario)
        {
            Venda venda = new Venda(veiculo, cliente, this, valor, horario);
            Vendas.Add(venda);
            return venda;
        }

        public Compra RealizarCompra(Veiculo veiculo, Fornecedor fornecedor, Decimal valor, DateTime horario)
        {
            Compra compra = new Compra(veiculo, fornecedor, this, valor, horario);
            Compras.Add(compra);
            return compra;
        }
    }
}