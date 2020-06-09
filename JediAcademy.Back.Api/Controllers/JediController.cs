using System.Collections.Generic;
using JediAcademy.Back.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace JediAcademy.Back.Api.Controllers
{
    [ApiController]
    [Route("api/jedi")]
    public class JediController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var jedi = new List<Jedi>{new Jedi{Id=0,Height = 77,Mass = 88,Name = "test", Species = "test"}};
            return Ok(jedi);
        }
    }


}
