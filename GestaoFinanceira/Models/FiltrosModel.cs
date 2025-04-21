namespace GestaoFinanceira.Models
{
    public class FiltrosModel
    {
        public FiltrosModel(string filtrostring)
        {
            FiltroString = filtrostring?? "todos-todos-todos";
        }

        public string FiltroString { get; set; }
        public string CategoriaId { get; set; }
        public string TransacaoId { get; set; }
        public string DataOperacao { get; set; }
    }
}
