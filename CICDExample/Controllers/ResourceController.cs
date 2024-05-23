using CICDExample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace CICDExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResourceController : ControllerBase
    {

        private readonly ICatanService _catanService;

        public ResourceController(ICatanService catanService)
        {
            _catanService = catanService;
        }

        [HttpGet]
        public IActionResult GetResources()
        {
            return Ok(_catanService.GetResources());
        }
    }
}
