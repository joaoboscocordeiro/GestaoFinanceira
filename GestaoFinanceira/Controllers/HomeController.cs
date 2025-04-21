using GestaoFinanceira.Data;
using GestaoFinanceira.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestaoFinanceira.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string id)
        {
            var filtros = new FiltrosModel(id);

            ViewBag.Filtros = filtros;
            ViewBag.Categorias = _context.Categorias.ToList();
            ViewBag.Transacoes = _context.Transacaos.ToList();

            IQueryable<FinanceiroModel> consulta = _context.Financas
                .Include(x => x.Transacao)
                .Include(x => x.Categoria);

            if (filtros.TemCategoria)
            {
                consulta = consulta.Where(c => c.CategoriaId == filtros.CategoriaId);
            };

            if (filtros.TemTransacao)
            {
                consulta = consulta.Where(c => c.TransacaoId == filtros.TransacaoId);
            };

            if (filtros.TemDataOperacao)
            {
                var hoje = DateTime.Today;

                if (filtros.EPassado)
                {
                    consulta = consulta.Where(c => c.DataDaOperacao < hoje);
                }

                if (filtros.EFuturo)
                {
                    consulta = consulta.Where(c => c.DataDaOperacao > hoje);
                }

                if (filtros.EHoje)
                {
                    consulta = consulta.Where(c => c.DataDaOperacao == hoje);
                }
            };

            var financas = consulta.OrderBy(d => d.DataDaOperacao).ToList();

            return View(financas);
        }
    }
}
