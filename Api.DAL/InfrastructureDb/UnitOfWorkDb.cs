using Api.DAL.DataContext;
using Api.DAL.InfrastructureDb.IRepository;
using Api.DAL.InfrastructureDb.Repository;


namespace Api.DAL.InfrastructureDb
{
    public class UnitOfWorkDb : IUnitOfWorkDb
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ICompanyRepository CompanyRepository { get; private set; }


        public UnitOfWorkDb(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            CompanyRepository = new CompanyRepository(applicationDbContext);

           
        }
        public async Task SaveAsync()
        {
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
