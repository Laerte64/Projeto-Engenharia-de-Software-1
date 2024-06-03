using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_estabelecimento")]
    internal class Estabelecimento
    {
        [Key]
        public int ID { get; set; } // Auto-implementado para compatibilidade com EF Core

        [Required] // Assegura que o campo n�o seja nulo no banco de dados
        [MaxLength(100)] // Define o tamanho m�ximo do campo no banco
        public string Estado { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(200)]
        public string Endereco { get; set; }

        // Construtor sem par�metros � importante para EF Core
        public Estabelecimento() {
        }

        // Construtor com par�metros para uso pr�tico
        public Estabelecimento(string estado, string cidade, string endereco)
        {
            Estado = estado;
            Cidade = cidade;
            Endereco = endereco;
        }
    }
}
