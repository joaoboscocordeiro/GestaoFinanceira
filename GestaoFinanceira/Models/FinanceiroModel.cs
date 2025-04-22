using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace GestaoFinanceira.Models
{
    public class FinanceiroModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite uma Descrição!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Digite um Valor!")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "Selecione uma Data!")]
        public DateTime DataDaOperacao { get; set; }
        
        [Required(ErrorMessage = "Selecione uma Categoria!")]
        public string CategoriaId { get; set; }
        [ValidateNever]
        public CategoriaModel Categoria { get; set; }

        [Required(ErrorMessage = "Selecione uma Transação!")]
        public string TransacaoId { get; set; }
        [ValidateNever]
        public TransacaoModel Transacao { get; set; }
    }
}
