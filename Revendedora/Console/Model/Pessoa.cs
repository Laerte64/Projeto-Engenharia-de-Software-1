using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_pessoa")]
    internal abstract class Pessoa
    {
        [Key]
        public int ID { get; set; }

     
        [MaxLength(100)]
        public string Nome { get; set; }
    
        [MaxLength(11)]
        public string CPF { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string cpf)
        {
            ID = 0;
            Nome = nome;
            CPF = cpf;
        }
    }
}