using Api.BLL.InfrastructureService.IServices;
using Api.BOL.Models;
using Api.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.BLL.InfrastructureService.Services
{
    public class TestServices : ITestSerevice
    {
        private readonly IUnitOfWorkDb _unitOfWorkDb;

        public TestServices(IUnitOfWorkDb unitOfWorkDb)
        {
            _unitOfWorkDb = unitOfWorkDb;
        }
        public async Task CreateAsync(Test model)
        {
            await _unitOfWorkDb.TestRepogitory.AddAsync(model);
            await _unitOfWorkDb.SaveAsync();
        }

        public async Task<IEnumerable<Test>> GetAllAsync()
        {
            return await _unitOfWorkDb.TestRepogitory.GetAllAsync();
        }

        public Task<Test> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
