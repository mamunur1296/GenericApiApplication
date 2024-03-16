using Api.DAL.DataContext;
using Api.DAL.InfrastructureDb.IRepository;
using Api.DAL.InfrastructureDb.Repository;


namespace Api.DAL.InfrastructureDb
{
    public class UnitOfWorkDb : IUnitOfWorkDb
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ICompanyRepository CompanyRepository { get; private set; }

        public ITraderRepogitory TraderRepogitory { get; private set; }

        public ITestRepogitory TestRepogitory { get; private set; }

        public UnitOfWorkDb(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            CompanyRepository = new CompanyRepository(applicationDbContext);
            TraderRepogitory = new TraderRepogitory(applicationDbContext);
            TestRepogitory = new TestRepogitory(applicationDbContext);
        }
        public async Task SaveAsync()
        {
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
