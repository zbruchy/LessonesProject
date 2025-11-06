using SchoolDigital.Core.Entities;
using SchoolDigital.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDigital.Data.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly DataContext _context;
        public AttendanceRepository(DataContext context)
        {
            _context = context;
        }
        public List<Attendance> GetAllAttendances()
        {
            return _context.attendances;
        }

        public Attendance GetById(int id)
        {
            var t = _context.attendances.Find(x => x.Id == id);
            return t;
        }
    }
}
