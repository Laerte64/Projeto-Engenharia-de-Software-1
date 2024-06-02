using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("tb_modelo")]
    internal class Modelo
    {
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
        public readonly string Motor;
        [Required]
        public readonly int NumeroPortas;
        [Required]
        [MaxLength(100)]
        public readonly string Transmissao;
        [Required]
        [MaxLength(100)]
        public readonly string Combustivel;

        public Modelo(string nome, string marca, int ano, string motor, int numeroPortas, string transmissao, string combustivel)
        {
            this.ID = 0;
            this.Nome = nome;
            this.Marca = marca;
            this.Ano = ano;
            this.Motor = motor;
            this.NumeroPortas = numeroPortas;
            this.Transmissao = transmissao;
            this.Combustivel = combustivel;
        }
    }
}
