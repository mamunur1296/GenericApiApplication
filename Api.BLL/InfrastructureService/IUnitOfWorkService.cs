

using Api.BLL.InfrastructureService.IServices;

namespace Api.BLL.InfrastructureService
{
    public interface IUnitOfWorkService 
    {
         ICompanyServices CompanyServices { get; }
  

        // Define Extra methods if This methods applay all App 
    }
}
