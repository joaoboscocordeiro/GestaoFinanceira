using System.ComponentModel.DataAnnotations;

namespace GestaoFinanceira.Models
{
    public class CategoriaModel
    {
        [Key]
        public string CategoriaId { get; set; }
        public string Nome { get; set; }
    }
}
