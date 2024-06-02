using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_fornecedor")]
    internal class Fornecedor
    {
        [Key]
        public readonly int ID;

        [Required]
        [MaxLength(100)]
        public readonly string Nome;

        [Required]
        [MaxLength(20)]
        public readonly string CNPJ;

        public Fornecedor(string nome, string cnpj)
        {
            ID = 0;
            Nome = nome;
            CNPJ = cnpj;
        }
    }
}
