using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.BLL.InfrastructureService.IGenerics
{
    public interface IGRepositryServices<T> : IEntityCreator<T>, IEntityReader<T> where T : class
    {
        // Add Common Methods Segnatures 
    }
}
