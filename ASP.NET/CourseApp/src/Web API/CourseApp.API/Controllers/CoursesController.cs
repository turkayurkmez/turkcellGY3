using CourseApp.DataTransferObjects.Requests;
using CourseApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        //Public API: REST: Representational (Temsili) State Transfer...

        private readonly ICourseService courseService;

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            var courses = courseService.GetCourseDisplayResponses();
            return Ok(courses);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCourse(int id)
        {
            var course = courseService.GetCourse(id);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> SearchCourseByName(string name)
        {
            var courses = await courseService.SearchByName(name);
            return Ok(courses);
        }

        [HttpGet("[action]")]
        public IActionResult GetCoursesByCategory(int id)
        {
            var courses = courseService.GetCoursesByCategory(id);
            return Ok(courses);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewCourseRequest request)
        {
            if (ModelState.IsValid)
            {
                var lastCourseId = await courseService.CreateCourseAndReturnIdAsync(request);
                return CreatedAtAction(nameof(GetCourse), routeValues: new { id = lastCourseId }, null);

            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateCourseRequest updateCourseRequest)
        {
            var isExists = await courseService.CourseIsExists(id);
            if (isExists)
            {
                if (ModelState.IsValid)
                {
                    await courseService.UpdateCourse(updateCourseRequest);
                    return Ok();
                }

                return BadRequest(ModelState);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await courseService.CourseIsExists(id))
            {
                await courseService.DeleteAsync(id);
                return Ok();
            }
            return NotFound();
        }


    }
}
