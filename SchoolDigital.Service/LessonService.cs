using SchoolDigital.Core.Entities;
using SchoolDigital.Core.Repositories;
using SchoolDigital.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDigital.Service
{
    internal class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        public LessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }
        public List<Lesson> GetAll()
        {
            return _lessonRepository.GetAllLessons();
        }

        public Lesson GetById(int id)
        {
            return _lessonRepository.GetById(id);
        }
    }
}
