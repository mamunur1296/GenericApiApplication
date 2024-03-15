using Api.DAL.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DAL.InfrastructureDb
{
    public class UnitOfWorkDb : IUnitOfWorkDb
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UnitOfWorkDb(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task SaveAsync()
        {
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
