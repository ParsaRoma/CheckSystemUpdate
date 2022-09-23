using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models.MainModels;
using Infra.Data.Context;
using Infra.Data.GenericRepository;

namespace Infra.Data.TypeRepositories
{
    public class OsInfoRepository : GenericRepository<OsInfo>, IOsInfoRepository
    {
        
         public OsInfoRepository(ApplicationDbContext context) : base(context)
        {
            

        }
    public void Insert(OsInfo entity)
        {
            var Insert = _context.Add(entity);
            _context.SaveChanges();        
        } 
    }
}