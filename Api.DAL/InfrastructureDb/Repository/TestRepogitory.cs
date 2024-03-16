using Api.BOL.Models;
using Api.DAL.DataContext;
using Api.DAL.InfrastructureDb.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DAL.InfrastructureDb.Repository
{
    public class TestRepogitory : GRepository<Test> , ITestRepogitory
    {
        private readonly ApplicationDbContext _context;

        public TestRepogitory(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        // Applay Company Extended db Login 
    }
}
