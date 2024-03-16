
using Api.DAL.InfrastructureDb.IRepository;

namespace Api.DAL
{
    public interface IUnitOfWorkDb
    {
        ICompanyRepository CompanyRepository { get; }
        ITraderRepogitory TraderRepogitory { get; }
        ITestRepogitory TestRepogitory { get; }
        Task SaveAsync();
    }
}
