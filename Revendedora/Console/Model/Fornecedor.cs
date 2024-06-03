using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_fornecedor")]
    internal class Fornecedor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(20)]
        public string CNPJ { get; set; }


        public Fornecedor()
        {

        }

        public Fornecedor(string nome, string cnpj)
        {
            ID = 0;
            Nome = nome;
            CNPJ = cnpj;
        }
    }
}
