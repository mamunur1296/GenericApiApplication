using Api.BOL.Models;
using Api.DAL.DataContext;
using Api.DAL.InfrastructureDb.IRepository;


namespace Api.DAL.InfrastructureDb.Repository
{
    public class TraderRepogitory : GRepository<Trader> , ITraderRepogitory
    {
        private readonly ApplicationDbContext _context;

        public TraderRepogitory(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        // Applay Company Extended db Login 
    }
}
