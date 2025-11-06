using SchoolDigital.Core.Entities;
using SchoolDigital.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDigital.Data.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        private readonly DataContext _context;
        public LessonRepository(DataContext context)
        {
            _context = context;
        }
        public List<Lesson> GetAllLessons()
        {
            return _context.lessons;
        }

        public Lesson GetById(int id)
        {
            var t = _context.lessons.Find(x => x.Id == id);
            return t;
        }
    }
}
