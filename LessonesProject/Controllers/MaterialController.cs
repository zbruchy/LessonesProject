using LessonesProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LessonesProject.Controllers
{
    [Route("api/lessons/{lessonId}/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        public IDatacontext _context { get; set; }
        public MaterialController(IDatacontext context)
        {
            _context = context;
        }
        // GET: api/<MaterialController>
        [HttpGet]
        public ActionResult Get(int lessonId)
        {
            var m = _context.materials.FirstOrDefault(m => m.LessonId == lessonId);
            if (m != null)
                return Ok(m);
            return NotFound();
        }

        // POST api/<MaterialController>
        [HttpPost]
        public ActionResult Post(int lessonId, [FromBody] Material value)
        {
            var m = _context.materials.Find(x => x.Id == value.Id);
            if (m != null)
                return Conflict(m);
            _context.materials.Add(value);
            return Ok();
        }

        // PUT api/<MaterialController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int lessonId, int id, [FromBody] Material value)
        {
            var index = _context.materials.FindIndex(m => m.Id == id && m.LessonId == lessonId);
            if (index >= 0)
            {
                _context.materials[index].Title = value.Title;
                _context.materials[index].Type = value.Type;
                _context.materials[index].Url = value.Url;
                return Ok();
            }
            return NotFound();
        }

        // DELETE api/<MaterialController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int lessonId, int id)
        {
            var material = _context.materials.FirstOrDefault(m => m.Id == id && m.LessonId == lessonId);
            if (material != null)
            {
                _context.materials.Remove(material);
            }
            return NotFound();   
        }
    }
}
