
using Api.DAL.InfrastructureDb.IRepository;

namespace Api.DAL
{
    public interface IUnitOfWorkDb
    {
        ICompanyRepository CompanyRepository { get; }
    
        Task SaveAsync();
    }
}
