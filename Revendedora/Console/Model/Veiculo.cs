using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_veiculo")]
    internal class Veiculo
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public Modelo Modelo { get; set; }

        [Required]
        public Condicao Condicao_ { get; set; }

        [Required]
        public Compra Compra { get; set; }

        public Venda? Venda { get; set; }

        [Required]
        public Estabelecimento Estabelecimento { get; set; } 

        public Veiculo()
        {

        }

        public Veiculo(Modelo modelo, Condicao condicao, Compra compra, Estabelecimento estabelecimento)
        {
            ID = 0;
            Modelo = modelo;
            Condicao_ = condicao;
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