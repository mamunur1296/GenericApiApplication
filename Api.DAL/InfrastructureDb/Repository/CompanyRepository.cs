using Api.BOL.Models;
using Api.DAL.DataContext;
using Api.DAL.InfrastructureDb.IRepository;


namespace Api.DAL.InfrastructureDb.Repository
{
    public class CompanyRepository : GRepository<Company>,ICompanyRepository
    {
        private readonly ApplicationDbContext _context;

        public CompanyRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }
        // Applay Company Extended db Login 
    }
}
