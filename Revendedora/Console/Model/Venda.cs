using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{

    [Table("tb_venda")]
    internal class Venda
    {
        [Key]
        public readonly int ID;
        [Required]
        public readonly Veiculo Veiculo;
        [Required]
        public readonly Cliente Cliente;
        [Required]
        public readonly Funcionario Funcionario;
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public readonly Decimal Valor;
        [Required]
        public readonly DateTime Horario;

        public Venda(Veiculo veiculo, Cliente cliente, Funcionario funcionario, Decimal valor, DateTime horario)
        {
            ID = 0;
            Veiculo = veiculo;
            Cliente = cliente;
            Funcionario = funcionario;
            Valor = valor;
            Horario = horario;
        }
    }
}