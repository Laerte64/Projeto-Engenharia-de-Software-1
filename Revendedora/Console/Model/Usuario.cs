using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_usuario")]
    internal class Usuario
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Login { get; set; }

        [MaxLength(100)]
        public string Senha { get; set; }

        public int FuncionarioID { get; set; }
        public Funcionario Funcionario { get; set; }

        public Usuario() {}

        public Usuario(string login, string senha)
        {
            ID = 0;
            Login = login;
            Senha = senha;
        }
    }
}