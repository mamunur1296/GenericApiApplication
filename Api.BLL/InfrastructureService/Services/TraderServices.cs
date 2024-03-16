using Api.BLL.InfrastructureService.IServices;
using Api.BOL.Models;
using Api.DAL;


namespace Api.BLL.InfrastructureService.Services
{
    public class TraderServices : ITraderServices
    {
        private readonly IUnitOfWorkDb _unitOfWorkDb;

        public TraderServices(IUnitOfWorkDb unitOfWorkDb)
        {
            _unitOfWorkDb = unitOfWorkDb;
        }
        public async Task CreateAsync(Trader model)
        {
            await _unitOfWorkDb.TraderRepogitory.AddAsync(model);
            await _unitOfWorkDb.SaveAsync();
        }

        public async Task<IEnumerable<Trader>> GetAllAsync()
        {
           return    await _unitOfWorkDb.TraderRepogitory.GetAllAsync();
        }

        public Task<Trader> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
