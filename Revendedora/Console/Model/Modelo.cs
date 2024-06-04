using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("tb_modelo")]
    internal class Modelo
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(100)]
        public string Marca { get; set; }

        public int Ano { get; set; }

        [MaxLength(100)]
        public string Motor { get; set; }

        public int NumeroPortas { get; set; }

        [MaxLength(100)]
        public string Transmissao { get; set; }

        [MaxLength(100)]
        public string Combustivel { get; set; }

        public Modelo() { }

        public Modelo(string nome, string marca, int ano)
        {
            this.ID = 0;
            this.Nome = nome;
            this.Marca = marca;
            this.Ano = ano;
        }
    }
}
