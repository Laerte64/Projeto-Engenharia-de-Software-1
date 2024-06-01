using System.ComponentModel.DataAnnotations;

class Usuario
{
    [Key]
    public int ID { get; private set; }
    [Required]
    [MaxLength(50)]
    public string Login { get; private set; }
    [Required]
    [MaxLength(100)]
    private string _senha { get; private set; }

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