using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_pessoa")]
    internal abstract class Pessoa
    {
        [Key]
        public int ID;

        [Required]
        [MaxLength(100)]
        public string Nome;
        [Required]
        [MaxLength(11)]
        public string CPF;

        public Pessoa() { }

        public Pessoa(string nome, string cpf)
        {
            ID = 0;
            Nome = nome;
            CPF = cpf;
        }
    }
}