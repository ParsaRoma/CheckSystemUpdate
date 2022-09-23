using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models.MainModels;

namespace Application.Services
{
    public class VersionCheck : IVersionCheck
    {
      private readonly IUnitOfWork _unit;

        public VersionCheck(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public bool VersionChecker(int version)
        {
            throw new NotImplementedException();
        }

        public void InsertVersion(OsInfo entity)
        {
            _unit.osInfoRepository.Insert(entity);
        }
    }
}