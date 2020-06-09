using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StarWars.Api.Controllers
{
    [ApiController]
    [Route("api/species")]
    public class SpeciesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var species = System.IO.File.ReadAllText("Data/Species.json");
            return Ok(species);
        }
    }
}
