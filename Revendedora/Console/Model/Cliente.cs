using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_cliente")]
    internal class Cliente : Pessoa
    {
        private List<Venda> _vendas = new List<Venda>();
        public IReadOnlyList<Venda> Vendas => _vendas.AsReadOnly();

  
        // Construtor parametrizado para uso prático
        public Cliente() : base()
        {
        }

        public bool AdicionarVenda(Venda venda)
        {
            if (venda.ID != ID)  // Ajuste necessário: Utilize ClienteID assumindo que Venda possui essa propriedade de chave estrangeira.
                return false;
            _vendas.Add(venda);
            return true;
        }
    }
}
