using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.TypeRepositories;

namespace Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        private IOsInfoRepository _OsInforepostory;
      

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _OsInforepostory = new OsInfoRepository(_context);
        }

        public IOsInfoRepository osInfoRepository => _OsInforepostory;

        public void Dispose()
        {
            _context.Dispose();
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}