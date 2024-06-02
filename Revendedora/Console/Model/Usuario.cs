using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_usuario")]
    internal class Usuario
    {
        [Key]
        public readonly int ID;
        [Required]
        [MaxLength(50)]
        public readonly string Login;
        [Required]
        [MaxLength(100)]
        private string _senha;
        [Required]
        private readonly Funcionario _funcionario;

        public Usuario(string login, string senha)
        {
            ID = 0;
            Login = login;
            _senha = senha;
        }

        private bool VerificarSenha(string senha)
        {
            return _senha.Equals(senha);
        }

        public bool AlterarSenha(string antiga, string nova)
        {
            if (!VerificarSenha(antiga))
                return false;
            _senha = nova;
            return true;
        }

        public Funcionario? AcessarSistema(string senha)
        {
            if (!VerificarSenha(senha))
                return null;
            return _funcionario;
        }
    }
}