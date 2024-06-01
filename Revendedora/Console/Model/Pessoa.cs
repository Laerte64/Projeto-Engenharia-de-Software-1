using System.ComponentModel.DataAnnotations;

abstract class Pessoa
{
    [Key]
    public int ID { get; private set; }
    [Required]
    [MaxLength(100)]
    public string Nome { get; private set; }
    [Required]
    [MaxLength(11)]
    public string CPF { get; private set; }
}