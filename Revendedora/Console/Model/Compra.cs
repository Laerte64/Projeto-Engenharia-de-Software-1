using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_compra")]
    internal class Compra
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public Veiculo Veiculo { get; set; }
        [Required]
        public Fornecedor Fornecedor { get; set; }
        [Required]
        public Funcionario Funcionario { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Valor { get; set; }
        [Required]
        public DateTime Horario { get; set; }

        public Compra()
        {

        }

        public Compra(Veiculo veiculo, Fornecedor fornecedor, Funcionario funcionario, Decimal valor, DateTime horario)
        {
            ID = 0;
            Veiculo = veiculo;
            Fornecedor = fornecedor;
            Funcionario = funcionario;
            Valor = valor;
            Horario = horario;
        }
    }
}