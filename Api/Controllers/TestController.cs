using Api.BLL.InfrastructureService;
using Api.BOL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IUnitOfWorkService _unitOfWorkService;

        public TestController(IUnitOfWorkService unitOfWorkService)
        {
            _unitOfWorkService = unitOfWorkService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _unitOfWorkService.TestSerevice.GetAllAsync();
            return Ok(data);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(Test model)
        {
            await _unitOfWorkService.TestSerevice.CreateAsync(model);
            return Ok();
        }
    }
}
