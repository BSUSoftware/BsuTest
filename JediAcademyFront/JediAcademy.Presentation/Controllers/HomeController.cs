using JediAcademy.Presentation.Services;
using JediAcademy.Presentation.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JediAcademy.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJediEnrollmentService _jediEnrollmentService;

        public HomeController(IJediEnrollmentService jediEnrollmentService)
        {
            _jediEnrollmentService = jediEnrollmentService;
        }

        public async Task<ViewResult> Index()
        {
            var (isSuccess, species) = await _jediEnrollmentService.GetAvailableSpecies();
            var viewModel = new JediEnrollmentViewModel();
            if (isSuccess)
            {
                viewModel.Species.AddRange(species.Select(s => new SelectListItem(s.Name,s.Id)));
            }
            return View(viewModel);
        }

        public async Task<IActionResult> ExistingStudents()
        {
            var (isSuccess, jediStudents) = await _jediEnrollmentService.GetExistingStudents();
            var viewModel = new ExistingStudentsViewModel();
            if (isSuccess)
            {
                viewModel.JediStudents = jediStudents;
            }
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
