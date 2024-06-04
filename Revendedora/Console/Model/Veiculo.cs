using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_veiculo")]
    internal class Veiculo
    {
        [Key]
        public int ID { get; set; }

        public int ModeloID { get; set; }
        public Modelo Modelo { get; set; }

        public Condicao _Condicao { get; set; }
            
        public int? CompraID { get; set; }
        public Compra? Compra { get; set; }

        public int? VendaID { get; set; }
        public Venda? Venda { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Valor { get; set; }

        public int EstabelecimentoID { get; set; }
        public Estabelecimento Estabelecimento { get; set; }

        public Veiculo() { }

        public Veiculo(Modelo modelo, Condicao condicao, int compraID, Estabelecimento estabelecimento)
        {
            ID = 0;
            Modelo = modelo;
            _Condicao = condicao;
            CompraID = compraID; // Armazena o ID da compra
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