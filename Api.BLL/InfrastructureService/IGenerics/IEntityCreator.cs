using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.BLL.InfrastructureService.IGenerics
{
    public interface IEntityCreator<T> where T : class
    {
        Task CreateAsync(T model);
    }
}
