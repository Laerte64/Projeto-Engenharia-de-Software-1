using System.ComponentModel.DataAnnotations;

namespace Model
{
    internal class Compra
    {
        [Key]
        public readonly int ID;
        [Required]
        public readonly Veiculo Veiculo;
        [Required]
        public readonly Fornecedor Fornecedor;
        [Required]
        public readonly Funcionario Funcionario;
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public readonly Decimal Valor;
        [Required]
        public readonly DateTime Horario;

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