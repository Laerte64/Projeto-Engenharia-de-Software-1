using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_veiculo")]
    internal class Veiculo
    {
        [Key]
        public readonly int ID;
        [Required]
        public readonly Modelo Modelo;
        [Required]
        public readonly Condicao _Condicao;
        [Required]
        public readonly Compra Compra;
        public readonly Venda? Venda;
        [Required]
        public readonly Estabelecimento Estabelecimento;

        public Veiculo(Modelo modelo, Condicao condicao, Compra compra, Estabelecimento estabelecimento)
        {
            ID = 0;
            Modelo = modelo;
            _Condicao = condicao;
            Compra = compra;
            Venda = null;
            Estabelecimento = estabelecimento;
        }

        public enum Condicao
        {
            Novo,
            Seminovo,
            Usado
        }
    }
}