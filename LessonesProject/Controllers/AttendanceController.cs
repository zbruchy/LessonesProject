using LessonesProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LessonesProject.Controllers
{
    [Route("api/lessons/{lessonId}/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        public static List<Attendance> attendances = new List<Attendance>();

        // GET: api/<AttendanceController>
        [HttpGet]
        public IEnumerable<Attendance> Get(int lessonId)
        {
            return attendances.Where(a => a.LessonId == lessonId);
        }

        // POST api/<AttendanceController>
        [HttpPost]
        public void Post(int lessonId, [FromBody] Attendance value)
        {
            value.Id = attendances.Count + 1;
            value.LessonId = lessonId;
            attendances.Add(value);
        }

        // PUT api/<AttendanceController>/5
        [HttpPut("{id}")]
        public void Put(int lessonId, int id, [FromBody] Attendance value)
        {
            var index = attendances.FindIndex(a => a.Id == id && a.LessonId == lessonId);
            if (index >= 0)
            {
                attendances[index].StudentId = value.StudentId;
                attendances[index].Status = value.Status;
            }
        }

        // DELETE api/<AttendanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int lessonId, int id)
        {
            var record = attendances.FirstOrDefault(a => a.Id == id && a.LessonId == lessonId);
            if (record != null)
                attendances.Remove(record);
        }
    }
}
