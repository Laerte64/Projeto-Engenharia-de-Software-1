using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{

    [Table("tb_venda")]
    internal class Venda
    {
        [Key]
        public int ID;
        [Required]
        public Veiculo Veiculo;
        [Required]
        public Cliente Cliente;
        [Required]
        public Funcionario Funcionario;
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Valor;
        [Required]
        public DateTime Horario;

        public Venda() { }

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