using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_cliente")]
    internal class Cliente : Pessoa
    {
        private List<Venda> Vendas = new List<Venda>();
        public Cliente() { }

        public Cliente(string nome, string cpf)
        {
            ID = 0;
            Nome = nome;
            CPF = cpf;
            Vendas = new List<Venda>();
        }

        public bool AdicionarVenda(Venda venda)
        {
            if (venda.ID != ID)
                return false;
            Vendas.Add(venda);
            return true;
        }
    }
}
