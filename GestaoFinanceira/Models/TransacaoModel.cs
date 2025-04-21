using System.ComponentModel.DataAnnotations;

namespace GestaoFinanceira.Models
{
    public class TransacaoModel
    {
        [Key]
        public string TransacaoId { get; set; }
        public string Nome { get; set; }
    }
}
