using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories.Interfaces;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
            
        {
            ViewData["Título"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;
            
            //var lanches = this._lancheRepository.Lanches;
            //var totalLanches = lanches.Count();
            //ViewBag.Total = "Total de Lanches : ";
            //ViewBag.TotalLanches = totalLanches;
           // return View(lanches);

            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            var totalLanches = lanchesListViewModel.Lanches.Count();
            ViewBag.TotalLanches = totalLanches;
            ViewBag.Total = "Total de Lanches : ";
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lanchesListViewModel);
        }
    }
}
