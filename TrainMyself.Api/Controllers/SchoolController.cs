using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainMyself.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace TrainMyself.Api.Controllers
{
    public class SchoolController: ControllerBase
    {
        private readonly DataContext _context;

        public SchoolController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("/School/getSchools")]
        public async Task<IActionResult> getSchools() {
            var schools = await _context.Schools.ToListAsync();
            return Ok(schools);
        }
    }
}