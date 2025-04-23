using System.ComponentModel.DataAnnotations;

namespace GestaoFinanceira.Models
{
    public class CategoriaModel
    {
        [Key]
        public string CategoriaId { get; set; }
        [Required(ErrorMessage = "Digite a categoria!")]
        public string Nome { get; set; }
    }
}
