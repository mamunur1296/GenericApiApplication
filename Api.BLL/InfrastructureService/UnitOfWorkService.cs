using Api.BLL.InfrastructureService.IServices;
using Api.BLL.InfrastructureService.Services;
using Api.DAL;


namespace Api.BLL.InfrastructureService
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly IUnitOfWorkDb _unitOfWorkDb;
        public ICompanyServices CompanyServices { get; private set; }


    

        public UnitOfWorkService(IUnitOfWorkDb unitOfWorkDb)
        {
            _unitOfWorkDb = unitOfWorkDb;
            CompanyServices = new CompanyServices(unitOfWorkDb);
            
        }

        // Extand common methods 
    }
}
