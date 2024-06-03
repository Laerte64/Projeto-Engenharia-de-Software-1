using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_funcionario")]
    internal class Funcionario : Pessoa
    {
        public Usuario? _usuario;
        public List<Venda> _vendas;
        public IReadOnlyList<Venda> Vendas => _vendas.AsReadOnly();
        public List<Compra> _compras;
        public IReadOnlyList<Compra> Compras => _compras.AsReadOnly();


        // Construtor parametrizado para uso prático
        public Funcionario() : base()
        {
        }

        public Funcionario(string nome, string cpf, Usuario? usuario) : base(nome, cpf)
        {
            _usuario = usuario;
            _vendas = new List<Venda>();
            _compras = new List<Compra>();
        }

        public Venda RealizarVenda(Veiculo veiculo, Cliente cliente, Decimal valor, DateTime horario)
        {
            Venda venda = new Venda(veiculo, cliente, this, valor, horario);
            _vendas.Add(venda);
            return venda;
        }

        public Compra RealizarCompra(Veiculo veiculo, Fornecedor fornecedor, Decimal valor, DateTime horario)
        {
            Compra compra = new Compra(veiculo, fornecedor, this, valor, horario);
            _compras.Add(compra);
            return compra;
        }
    }
}