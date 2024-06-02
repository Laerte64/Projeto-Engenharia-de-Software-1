using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_pessoa")]
    internal abstract class Pessoa
    {
        [Key]
        public readonly int ID;
        [Required]
        [MaxLength(100)]
        public readonly string Nome;
        [Required]
        [MaxLength(11)]
        public readonly string CPF;

        public Pessoa(string nome, string cpf)
        {
            ID = 0;
            Nome = nome;
            CPF = cpf;
        }
    }
}