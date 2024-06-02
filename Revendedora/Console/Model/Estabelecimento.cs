using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("tb_estabelecimento")]
    internal class Estabelecimento
    {
        [Key]
        public readonly int ID;
        [Required]
        [MaxLength(100)]
        public readonly string Estado;
        [Required]
        [MaxLength(100)]
        public readonly string Cidade;
        [Required]
        [MaxLength(100)]
        public readonly string Endereco;

        public Estabelecimento(string estado, string cidade, string endereco)
        {
            ID = 0;
            Estado = estado;
            Cidade = cidade;
            Endereco = endereco;
        }
    }
}
