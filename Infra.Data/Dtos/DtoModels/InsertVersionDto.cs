using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models.MainModels;

namespace Infra.Data.DtoModels
{
    public class InsertVersionDto  
    {
    
    public InsertVersionDto()
    {}
    
    public string? OsName { get; set; }
    public int OsVersion { get; set; }
    
    }
}