using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;

using Domain.Models.MainModels;
using Infra.Data.DtoModels;
using Mapster;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    public class CheckVersionController : ControllerBase
    {
        private readonly IVersionCheck _versionCheck;
        private readonly IMapper _mapper;
        public CheckVersionController(IVersionCheck versionCheck, IMapper mapper)
        {
            _versionCheck = versionCheck;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("api/Insert")]
        public  IActionResult Insert([FromBody] InsertVersionDto dto)
        {
            var result = dto.Adapt<OsInfo>();
            _versionCheck.InsertVersion(result);
            return Ok();
            
        } 
        
    }
}