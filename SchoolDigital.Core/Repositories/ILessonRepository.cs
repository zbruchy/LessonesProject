using SchoolDigital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDigital.Core.Repositories
{
    public interface ILessonRepository
    {
        public List<Lesson> GetAllLessons();
        public Lesson GetById(int id);
    }
}
