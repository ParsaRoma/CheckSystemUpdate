using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IOsInfoRepository osInfoRepository{
            get;
        }
        int Save();
        
    }
}