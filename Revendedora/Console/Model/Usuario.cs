using System.ComponentModel.DataAnnotations;

namespace Model
{
    internal class Usuario : Pessoa
    {
        [Key]
        public int ID { get; private set; }
        [Required]
        [MaxLength(50)]
        public string Login { get; private set; }
        [Required]
        [MaxLength(100)]
        private string _senha;

        public bool VerificarSenha(string senha)
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
    }
}