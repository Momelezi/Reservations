using Business;
using Business.Database;
using Microsoft.AspNetCore.Mvc;
using QA.Models;
using System.Diagnostics;

namespace QA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositoryContext _repositoryContext;
        public HomeController(ILogger<HomeController>logger, RepositoryContext repository)
        {
            _logger = logger;
            _repositoryContext = repository;
        }

        public IActionResult Index()
        {

            var branchViewModel = new BranchesViewModel
            {
                 Branches = _repositoryContext.Branches.ToList(),

            };


            return View(branchViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}