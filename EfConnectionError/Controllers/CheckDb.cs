using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfConnectionError.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EfConnectionError.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckDb : ControllerBase
    {
        private readonly EfConnectionErrorContext _dbContext;

        public CheckDb(EfConnectionErrorContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _dbContext.Database.OpenConnectionAsync();
            return Ok("Ok");
        }
    }
}