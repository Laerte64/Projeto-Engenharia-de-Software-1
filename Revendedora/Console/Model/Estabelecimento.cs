using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_estabelecimento")]
    internal class Estabelecimento
    {
        [Key]
        public int ID;

        [Required]
        [MaxLength(100)]
        public string Estado;

        [Required]
        [MaxLength(100)]
        public string Cidade;

        [Required]
        [MaxLength(200)]
        public string Endereco;

        
        public Estabelecimento() { }

        
        public Estabelecimento(string estado, string cidade, string endereco)
        {
            ID = 0;
            Estado = estado;
            Cidade = cidade;
            Endereco = endereco;
        }
    }
}
