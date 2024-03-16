using Api.BLL.InfrastructureService;
using Api.BOL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IUnitOfWorkService _unitOfWorkService;

        public CompanyController(IUnitOfWorkService unitOfWorkService)
        {
            _unitOfWorkService = unitOfWorkService;
        }

        // Let,s Mack your  Api 
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll() 
        {
            var data = await _unitOfWorkService.CompanyServices.GetAllAsync();
            return Ok(data);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(Company model)
        {
            await _unitOfWorkService.CompanyServices.CreateAsync(model);
            return Ok();
        }
    }
}
