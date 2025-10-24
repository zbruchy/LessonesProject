using LessonesProject.Entities;

namespace LessonesProject
{
    public interface IDatacontext
    {
        public List<Lesson> lessons { get; set; }
        public List<Attendance> attendances { get; set; }
        public List<Material> materials { get; set; }
        public List<User> users { get; set; }
    }
}

