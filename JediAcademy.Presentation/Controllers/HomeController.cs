using JediAcademy.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using JediAcademy.Application.Queries;
using JediAcademy.Domain.Services;
using MediatR;

namespace JediAcademy.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<ViewResult> Index()
        {
            var (isSuccess, result) = await _mediator.Send(new RetrieveSpecies.Query());
            var viewModel = new JediEnrollmentViewModel();
            if (isSuccess)
            {
                viewModel.Species.AddRange(result.Select(s => new SelectListItem(s.Name,s.Id)));
            }
            return View(viewModel);
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
