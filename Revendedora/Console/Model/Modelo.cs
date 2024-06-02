using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_modelo")]
    internal class Modelo
    {
        [Key]
        public readonly int ID;
        [Required]
        [MaxLength(100)]
        public readonly string Nome;
        [Required]
        [MaxLength(100)]
        public readonly string Marca;
        [Required]
        public readonly int Ano;
        [Required]
        [MaxLength(100)]
        public string Motor;
        [Required]
        public int NumeroPortas;
        [Required]
        [MaxLength(100)]
        public string Transmissao;
        [Required]
        [MaxLength(100)]
        public string Combustivel;

        public Modelo(string nome, string marca, int ano)
        {
            this.ID = 0;
            this.Nome = nome;
            this.Marca = marca;
            this.Ano = ano;
        }
    }
}
