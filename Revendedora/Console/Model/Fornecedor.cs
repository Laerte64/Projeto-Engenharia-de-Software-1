using System.ComponentModel.DataAnnotations;
namespace Model
{
    internal class Fornecedor
    {
        [Key]
        public int ID {get; private set;}

        [Required]
        [MaxLength(100)]
        public string Nome {get; set;}

        [Required]
        [MaxLength(20)]
        public string CNPJ {get; set;}
    }
}
