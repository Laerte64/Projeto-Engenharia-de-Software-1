using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_compra")]
    internal class Compra
    {
        [Key]
        public int ID;
        [Required]
        public Veiculo Veiculo;
        [Required]
        public Fornecedor Fornecedor;
        [Required]
        public Funcionario Funcionario;
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Valor;
        [Required]
        public DateTime Horario;

        public Compra() { }

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