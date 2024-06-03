using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_veiculo")]
    internal class Veiculo
    {
        [Key]
        public int ID;

        [Required]
        public Modelo Modelo;

        [Required]
        public Condicao _Condicao;

        [Required]
        public Compra Compra;

        public Venda? Venda;

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Valor;

        [Required]
        public Estabelecimento Estabelecimento;

        public Veiculo() { }

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