using Infrastructure.Contexts;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("/courses")]
    [ApiController]
    public class CoursesController(CoursesDbContext context) : ControllerBase
    {
        private readonly CoursesDbContext _context = context;

        [HttpPost]
        public async Task<IActionResult> Create(CourseRegistrationForm form)
        {

            if (ModelState.IsValid)
            {
                var course = CourseFactory.Create(form);


                _context.Courses.Add(course);
                await _context.SaveChangesAsync();

                return Created("", course);
            }
            return BadRequest();
        }
    }
}
