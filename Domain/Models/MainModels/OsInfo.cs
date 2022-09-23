using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.BaseEntities;

namespace Domain.Models.MainModels
{
    public class OsInfo : BaseEntity
    {
        [Required(ErrorMessage ="OsName is requied")]
        public string? OsName { get; set; }
        
        
        [Required(ErrorMessage ="OsVersion is required")]
         public string? OsVersion { get; set; }
    }
}