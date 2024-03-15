using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.BLL.InfrastructureService.IGenerics
{
    public interface IEntityRemover<T> where T : class
    {
        Task DeleteAsync(int id);
    }
}
