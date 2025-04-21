using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace GestaoFinanceira.Models
{
    public class FinanceiroModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataDaOperacao { get; set; }

        public string CategoriaId { get; set; }
        [ValidateNever]
        public CategoriaModel Categoria { get; set; }

        public string TransacaoId { get; set; }
        [ValidateNever]
        public TransacaoModel Transacao { get; set; }
    }
}
