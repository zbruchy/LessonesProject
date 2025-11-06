using SchoolDigital.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using SchoolDigital.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolDigital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;
        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
        // GET: api/<LessonController>
        [HttpGet]
        public IEnumerable<Lesson> Get()
        {
            return _lessonService.GetAll();
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var lesson = _lessonService.GetById(id);
            if (lesson != null)
                return Ok(lesson);
            return NotFound();
        }

        // POST api/<LessonController>
        [HttpPost]
        public ActionResult Post([FromBody] Lesson value)
        {
            /*var l = _context.lessons.Find(x => x.Id == value.Id);
            if (l != null)
            {
                return Conflict();
            }
            _context.lessons.Add(value);*/
            return Ok();
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Lesson value)
        {
            /*var index = _context.lessons.FindIndex(l => l.Id == id);
            if (index >= 0)
            {
                _context.lessons[index].Title = value.Title;
                _context.lessons[index].TeacherId = value.TeacherId;
                _context.lessons[index].Date = value.Date;
                _context.lessons[index].Duration = value.Duration;
                _context.lessons[index].Description = value.Description;
                return Ok();
            }*/
            return NotFound();
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            /*var lesson = _context.lessons.FirstOrDefault(lesson => lesson.Id == id);
            if (lesson != null)
            {
                _context.lessons.Remove(lesson);
                return Ok();
            }*/
            return NotFound();
        }
    }
}
