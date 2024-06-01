using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    internal class Veiculo
    {
        [Key]
        public int ID { get; private set; }

        [Required]
        public int ModeloID { get; private set; }
        [ForeignKey("ModeloID")]
        public Modelo Modelo { get; private set; }

        [Required]
        public Condicao _Condicao { get; private set; }

        [Required]
        public int CompraID { get; private set; }
        [ForeignKey("CompraID")]
        public Compra Compra { get; private set; }

        public int? VendaID { get; private set; }
        [ForeignKey("VendaID")]
        public Venda? Venda { get; private set; }

        [Required]
        public int EstabelecimentoID { get; private set; }
        [ForeignKey("EstabelecimentoID")]
        public Estabelecimento Estabelecimento { get; private set; }

        public Veiculo(int id, int modeloID, Modelo modelo, Condicao condicao, int compraID, Compra compra, int? vendaID, Venda? venda, int estabelecimentoID, Estabelecimento estabelecimento)
        {
            ID = id;
            ModeloID = modeloID;
            Modelo = modelo;
            _Condicao = condicao;
            CompraID = compraID;
            Compra = compra;
            VendaID = vendaID;
            Venda = venda;
            EstabelecimentoID = estabelecimentoID;
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