using Api.BLL.InfrastructureService.IServices;
using Api.BOL.Models;
using Api.DAL;


namespace Api.BLL.InfrastructureService.Services
{
    public class CompanyServices : ICompanyServices
    {
        private readonly IUnitOfWorkDb _unitOfWorkDb;

        public CompanyServices(IUnitOfWorkDb unitOfWorkDb)
        {
            _unitOfWorkDb = unitOfWorkDb;
        }

        public async Task CreateAsync(Company model)
        {
            await _unitOfWorkDb.CompanyRepository.AddAsync(model);
            await _unitOfWorkDb.SaveAsync();
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _unitOfWorkDb.CompanyRepository.GetAllAsync();
        }

        public Task<Company> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
