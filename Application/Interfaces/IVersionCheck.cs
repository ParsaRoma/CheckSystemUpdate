using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models.MainModels;

namespace Application.Interfaces
{
    public interface IVersionCheck
    {
        public void InsertVersion(OsInfo entity);
        public bool VersionChecker(int version);
    }
}