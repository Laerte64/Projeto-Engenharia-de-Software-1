using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_cliente")]
    internal class Cliente : Pessoa
    {
        private readonly List<Venda> _vendas;
        public IReadOnlyList<Venda> Vendas => _vendas.AsReadOnly();

        public Cliente(string nome, string cpf) : base(nome, cpf)
        {
            _vendas = new List<Venda>();
        }

        public bool AdicionarVenda(Venda venda)
        {
            if (venda.Cliente.ID != ID)
                return false;
            _vendas.Add(venda);
            return true;
        }
    }
}