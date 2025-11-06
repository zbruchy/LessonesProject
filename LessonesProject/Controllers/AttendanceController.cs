using SchoolDigital.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using SchoolDigital.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolDigital.Controllers
{
    [Route("api/lessons/{lessonId}/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService _attendanceService;
        public AttendanceController(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        // GET: api/<AttendanceController>
        [HttpGet]
        public ActionResult Get(int lessonId)
        {
            var a = _attendanceService.GetById(lessonId);
            if (a != null)
                return Ok(a);
            return NotFound();
        }

        // POST api/<AttendanceController>
        [HttpPost]
        public ActionResult Post(int lessonId, [FromBody] Attendance value)
        {
            /*var a = _context.attendances.Find(x => x.Id == value.Id);
            if (a != null)
                return Conflict(a);
            _context.attendances.Add(value);*/
            return Ok();
        }

        // PUT api/<AttendanceController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int lessonId, int id, [FromBody] Attendance value)
        {
           /* var index = _context.attendances.FindIndex(a => a.Id == id && a.LessonId == lessonId);
            if (index >= 0)
            {
                _context.attendances[index].StudentId = value.StudentId;
                _context.attendances[index].Status = value.Status;
                return Ok();
            }*/
            return NotFound();
        }

        // DELETE api/<AttendanceController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int lessonId, int id)
        {
            /*var record = _context.attendances.FirstOrDefault(a => a.Id == id && a.LessonId == lessonId);
            if (record != null)
            {
                _context.attendances.Remove(record);
                return Ok();
            }*/
            return BadRequest();
        }
    }
}
