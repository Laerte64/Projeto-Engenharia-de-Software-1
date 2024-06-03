using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_usuario")]
    internal class Usuario
    {
        [Key]
        public int ID;

        [Required]
        [MaxLength(50)]
        public string Login;

        [Required]
        [MaxLength(100)]
        public string Senha;
        public Funcionario Funcionario;

        public Usuario() {}

        public Usuario(string login, string senha)
        {
            ID = 0;
            Login = login;
            Senha = senha;
        }
    }
}