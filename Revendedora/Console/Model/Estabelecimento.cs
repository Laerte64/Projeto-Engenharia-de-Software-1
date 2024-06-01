using System.ComponentModel.DataAnnotations;

namespace Model
{
    internal class Estabelicimento
    {
        [Key]
        public int ID {get; set;}
        public string Estado {get; set;}
        public string Cidade {get; set;}
        public string Endereco {get; set;}
    }
}
