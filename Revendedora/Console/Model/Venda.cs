using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{

    [Table("tb_venda")]
    internal class Venda
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public Veiculo Veiculo { get; set; }
        [Required]
        public Cliente Cliente { get; set; }
        [Required]
        public Funcionario Funcionario { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Valor { get; set; }
        [Required]
        public DateTime Horario { get; set; }

        public Venda()
        {

        }

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