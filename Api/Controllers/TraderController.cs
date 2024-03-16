
using Api.BLL.InfrastructureService;
using Api.BOL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraderController : ControllerBase
    {
        private readonly IUnitOfWorkService _unitOfWorkService;

        public TraderController(IUnitOfWorkService unitOfWorkService)
        {
            _unitOfWorkService = unitOfWorkService;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(Trader model)
        {
            await _unitOfWorkService.TraderServices.CreateAsync(model);
            return Ok();
        }
    }
}
