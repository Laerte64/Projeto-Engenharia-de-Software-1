using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_compra")]
    internal class Compra
    {
        [Key]
        public int ID { get; set; }
        
        public int VeiculoID { get; set; }
        public Veiculo Veiculo { get; set; }

        public int FornecedorID { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public int FuncionarioID { get; set; }
        public Funcionario Funcionario { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Valor { get; set; }
  
        public DateTime Horario { get; set; }

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