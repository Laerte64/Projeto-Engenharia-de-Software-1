using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_usuario")]
    internal class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [MaxLength(100)]
        public string Senha { get; set; }
        public Funcionario Funcionario { get; set; }

        public Usuario()
        {

        }

    }
}