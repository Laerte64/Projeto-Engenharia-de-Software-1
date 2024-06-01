using System.ComponentModel.DataAnnotations;

namespace Model
{
    internal class Compra
    {
        [Key]
        public int Id { get; set; }
        public int VeiculoID { get; set; }
        public Veiculo Veiculo { get; set; }
        public int FornecedorID {  get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int FuncionarioID { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}