using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("tb_modelo")]
    internal class Modelo
    {
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        public string Marca { get; set; }

        [Required]
        public int Ano { get; set; }

        [Required]
        [MaxLength(100)]
        public string Motor { get; set; }

        [Required]
        public int NumeroPortas { get; set; }

        [Required]
        [MaxLength(100)]
        public string Transmissao { get; set; }

        [Required]
        [MaxLength(100)]
        public string Combustivel { get; set; }
    }
}
