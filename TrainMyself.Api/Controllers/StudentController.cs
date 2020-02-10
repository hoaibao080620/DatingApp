using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainMyself.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace TrainMyself.Controllers
{
    public class StudentController : ControllerBase
    {
        private readonly DataContext _context;

        public StudentController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> getStudents() {
            var students = await _context.Students.ToListAsync();
            return Ok(students);
        }
    }
}
